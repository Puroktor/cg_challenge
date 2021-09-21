﻿using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace cg_challenge
{
    public partial class Form1 : Form
    {
        private Matrix points;
        public Form1()
        {
            InitializeComponent();
            openFileDialog.Filter = "Point files|*.pnt";
            openFileDialog.FileName = null;
        }

        private void Draw()
        {
            if (pictureBox.Width == 0 || pictureBox.Height == 0)
                return;
            Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bmp);
            int w = pictureBox.Width / 2, h = pictureBox.Height / 2;
            g.TranslateTransform(w, h);
            g.ScaleTransform(1, -1);
            DrawAxes(g, w, h);
            if (points == null) { pictureBox.Image = bmp; return; }
            Pen pen = new Pen(Color.Black);
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

        private static void DrawAxes(Graphics g, int w, int h)
        {
            Pen pen = new Pen(Color.Red);
            int interval = 20;
            g.DrawLine(pen, -w, 0, w, 0);
            g.FillPolygon(Brushes.Red, new Point[] { new Point(w, 0), new Point(w - 10, 5), new Point(w - 10, -5) });
            for (int i = 1; i * interval < w - 10; i++)
            {
                g.DrawLine(pen, i * interval, -3, i * interval, 3);
                g.DrawLine(pen, -i * interval, -3, -i * interval, 3);
            }
            g.DrawLine(pen, 0, -h, 0, h);
            g.FillPolygon(Brushes.Red, new Point[] { new Point(0, h), new Point(5, h - 10), new Point(-5, h - 10) });
            for (int i = 1; i * interval < h - 10; i++)
            {
                g.DrawLine(pen, -3, i * interval, 3, i * interval);
                g.DrawLine(pen, -3, -i * interval, 3, -i * interval);
            }
        }

        private void openButton_Click(object sender, EventArgs e)
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

        private void scalePlusButton_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}