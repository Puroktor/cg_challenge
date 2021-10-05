using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace cg_challenge
{
    public partial class Form1 : Form
    {
        private Matrix points;
        private Matrix axisPoints = new Matrix(4, 3);
        private readonly Matrix T = new Matrix(3, 3);
        private float interval = 40;
        public Form1()
        {
            InitializeComponent();
            this.pictureBox.MouseWheel += PictureBox_MouseWheel;
            openFileDialog.Filter = "Point files|*.pnt";
            openFileDialog.FileName = null;
            float w = pictureBox.Width / 2F, h = pictureBox.Height / 2F;
            axisPoints[0, 0] = -w;
            axisPoints[0, 1] = 0;
            axisPoints[0, 2] = 1;
            axisPoints[1, 0] = w;
            axisPoints[1, 1] = 0;
            axisPoints[1, 2] = 1;
            axisPoints[2, 0] = 0;
            axisPoints[2, 1] = -h;
            axisPoints[2, 2] = 1;
            axisPoints[3, 0] = 0;
            axisPoints[3, 1] = h;
            axisPoints[3, 2] = 1;
            pictureBox.Focus();
            Draw();
        }

        private void Draw()
        {
            if (pictureBox.Width == 0 || pictureBox.Height == 0 || axisPoints[0, 0] == 0)
                return;
            int w = pictureBox.Width, h = pictureBox.Height;
            Bitmap bmp = new Bitmap(w, h);
            Graphics g = Graphics.FromImage(bmp);
            g.TranslateTransform(w / 2F, h / 2F);
            DrawAxes(g, w / 2F, h / 2F);
            if (points == null) { pictureBox.Image = bmp; return; }
            Pen pen = new Pen(Color.Black, 2);
            for (int i = 0; i < points.n - 1; i++)
            {
                g.DrawLine(pen, points[i, 0] / points[i, 2], points[i, 1] / points[i, 2],
                    points[i + 1, 0] / points[i + 1, 2], points[i + 1, 1] / points[i + 1, 2]);
            }
            if (points.n > 1)
            {
                g.DrawLine(pen, points[0, 0] / points[0, 2], points[0, 1] / points[0, 2],
                    points[points.n - 1, 0] / points[points.n - 1, 2], points[points.n - 1, 1] / points[points.n - 1, 2]);
            }
            pictureBox.Image = bmp;
        }

        private void DrawAxes(Graphics g, float w, float h)
        {
            Pen pen = new Pen(Color.Red, 2);
            Pen dashPen = new Pen(Color.PaleVioletRed);
            dashPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            float x1 = -w;
            float y1 = axisPoints[0, 1] / axisPoints[0, 2];
            float x2 = w;
            float y2 = axisPoints[1, 1] / axisPoints[1, 2];
            float x3 = axisPoints[2, 0] / axisPoints[2, 2];
            float y3 = -h;
            float x4 = axisPoints[3, 0] / axisPoints[3, 2];
            float y4 = h;
            g.DrawLine(pen, x1, y1, x2, y2);
            for (int i = 1; x3 - i * interval > x1; i++)
            {
                g.DrawLine(dashPen, x3 - i * interval, y3, x3 - i * interval, y4);
            }
            for (int i = 1; x3 + i * interval < x2; i++)
            {
                g.DrawLine(dashPen, x3 + i * interval, y3, x3 + i * interval, y4);
            }
            g.DrawLine(pen, x3, y3, x4, y4);
            for (int i = 1; y1 - i * interval > y3; i++)
            {
                g.DrawLine(dashPen, x1, y1 - i * interval, x2, y1 - i * interval);
            }
            for (int i = 1; y1 + i * interval < y4; i++)
            {
                g.DrawLine(dashPen, x1, y1 + i * interval, x2, y1 + i * interval);
            }
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileText = System.IO.File.ReadAllText(openFileDialog.FileName);
            string[] strPoints = fileText.Split('\n');
            points = new Matrix(strPoints.Length, 3);
            for (int i = 0; i < strPoints.Length; i++)
            {
                int[] xy = strPoints[i].Split(' ').Select(a => int.Parse(a)).ToArray();
                points[i, 0] = xy[0];
                points[i, 1] = xy[1];
                points[i, 2] = 1;
            }
            Draw();
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void PictureBox_MouseWheel(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            T.ClearMatrix();
            float delta = e.Delta / 2000F;
            T[0, 0] = 1F + delta;
            T[1, 1] = 1F + delta;
            T[2, 0] = -(e.X - pictureBox.Width / 2F) * delta;
            T[2, 1] = -(e.Y - pictureBox.Height / 2F) * delta;
            T[2, 2] = 1F;
            points *= T;
            axisPoints *= T;
            interval *= T[0, 0];
            Draw();
        }

        private void ScalePlusButton_Click(object sender, EventArgs e) => ScaleEqually(false);

        private void ScaleMinusButton_Click(object sender, EventArgs e) => ScaleEqually(true);

        private void RotatePlusButton_Click(object sender, EventArgs e) => Rotate(true);

        private void RotateMinusButton_Click(object sender, EventArgs e) => Rotate(false);

        private void TransfXPbutton_Click(object sender, EventArgs e) => Transform(0, false);

        private void TransfXMbutton_Click(object sender, EventArgs e) => Transform(0, true);

        private void TransfYPbutton_Click(object sender, EventArgs e) => Transform(1, false);

        private void TransfYMbutton_Click(object sender, EventArgs e) => Transform(1, true);

        private void MinusXScaleButton_Click(object sender, EventArgs e) => ScaleOneDimention(0, true);

        private void MinusYScaleButton_Click(object sender, EventArgs e) => ScaleOneDimention(1, true);

        private void PlusXScaleButton_Click(object sender, EventArgs e) => ScaleOneDimention(0, false);

        private void PlusYScaleButton_Click(object sender, EventArgs e) => ScaleOneDimention(1, false);

        private void ScaleEqually(bool needMinus)
        {
            T.ClearMatrix();
            float percent = (needMinus ? -1 : 1) * percentageTrackBar.Value / 100F;
            T[0, 0] = 1F + percent;
            T[1, 1] = 1F + percent;
            T[2, 2] = 1F;
            points *= T;
            Draw();
        }
        private void Rotate(bool needMinus)
        {
            T.ClearMatrix();
            double degree = (needMinus ? -1 : 1) * degreeTrackBar.Value * (Math.PI / 180.0);
            T[0, 0] = (float)Math.Cos(degree);
            T[0, 1] = (float)Math.Sin(degree);
            T[1, 0] = -(float)Math.Sin(degree);
            T[1, 1] = (float)Math.Cos(degree);
            T[2, 2] = 1F;
            points *= T;
            Draw();
        }

        private void Transform(int cell, bool needMinus)
        {
            T.ClearMatrix();
            float px = (needMinus ? -1 : 1) * pxTrackBar.Value;
            T[0, 0] = 1F;
            T[1, 1] = 1F;
            T[2, 2] = 1F;
            T[2, cell] = px;
            points *= T;
            Draw();
        }

        private void ScaleOneDimention(int cell, bool needMinus)
        {
            T.ClearMatrix();
            float percent = (needMinus ? -1 : 1) * percentageTrackBar.Value / 100F;
            T[cell, cell] = 1F + percent;
            T[1 - cell, 1 - cell] = 1F;
            T[2, 2] = 1F;
            points *= T;
            Draw();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            T.ClearMatrix();
            T[0, 0] = 1F; T[1, 1] = 1F; T[2, 2] = 1F;
            switch (e.KeyCode)
            {
                case Keys.Up: T[2, 1] = 5F; break;
                case Keys.Down: T[2, 1] = -5F; break;
                case Keys.Right: T[2, 0] = -5F; break;
                case Keys.Left: T[2, 0] = 5F; break;
                default: return;
            }
            points *= T;
            axisPoints *= T;
            Draw();
        }

        private void PercentageTrackBar_ValueChanged(object sender, EventArgs e)
        {
            percentageLabel.Text = ((TrackBar)sender).Value.ToString();
        }

        private void DegreeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            degreeLabel.Text = ((TrackBar)sender).Value.ToString();
        }

        private void PxTrackBar_ValueChanged(object sender, EventArgs e)
        {
            pxLabel.Text = ((TrackBar)sender).Value.ToString();
        }
    }
}
