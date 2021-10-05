
namespace cg_challenge
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel = new System.Windows.Forms.Panel();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.pxTrackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.degreeTrackBar = new System.Windows.Forms.TrackBar();
            this.percentageTrackBar = new System.Windows.Forms.TrackBar();
            this.plusYScaleButton = new System.Windows.Forms.Button();
            this.plusXScaleButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.minusYScaleButton = new System.Windows.Forms.Button();
            this.minusXScaleButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.transfYMbutton = new System.Windows.Forms.Button();
            this.transfYPbutton = new System.Windows.Forms.Button();
            this.transfXMbutton = new System.Windows.Forms.Button();
            this.transfXPbutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.rotateMinusButton = new System.Windows.Forms.Button();
            this.rotatePlusButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.scaleMinusButton = new System.Windows.Forms.Button();
            this.scalePlusButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.degreeLabel = new System.Windows.Forms.Label();
            this.pxLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentageTrackBar)).BeginInit();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1267, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(120, 26);
            this.openButton.Text = "Открыть файл";
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Menu;
            this.panel.Controls.Add(this.pxLabel);
            this.panel.Controls.Add(this.degreeLabel);
            this.panel.Controls.Add(this.percentageLabel);
            this.panel.Controls.Add(this.pxTrackBar);
            this.panel.Controls.Add(this.label8);
            this.panel.Controls.Add(this.label7);
            this.panel.Controls.Add(this.label6);
            this.panel.Controls.Add(this.degreeTrackBar);
            this.panel.Controls.Add(this.percentageTrackBar);
            this.panel.Controls.Add(this.plusYScaleButton);
            this.panel.Controls.Add(this.plusXScaleButton);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.minusYScaleButton);
            this.panel.Controls.Add(this.minusXScaleButton);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.transfYMbutton);
            this.panel.Controls.Add(this.transfYPbutton);
            this.panel.Controls.Add(this.transfXMbutton);
            this.panel.Controls.Add(this.transfXPbutton);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.rotateMinusButton);
            this.panel.Controls.Add(this.rotatePlusButton);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.scaleMinusButton);
            this.panel.Controls.Add(this.scalePlusButton);
            this.panel.Controls.Add(this.label1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel.Location = new System.Drawing.Point(1067, 30);
            this.panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(200, 738);
            this.panel.TabIndex = 0;
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentageLabel.Location = new System.Drawing.Point(153, 367);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(17, 18);
            this.percentageLabel.TabIndex = 23;
            this.percentageLabel.Text = "5";
            // 
            // pxTrackBar
            // 
            this.pxTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pxTrackBar.LargeChange = 10;
            this.pxTrackBar.Location = new System.Drawing.Point(0, 522);
            this.pxTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.pxTrackBar.Maximum = 99;
            this.pxTrackBar.Minimum = 1;
            this.pxTrackBar.Name = "pxTrackBar";
            this.pxTrackBar.Size = new System.Drawing.Size(200, 56);
            this.pxTrackBar.SmallChange = 5;
            this.pxTrackBar.TabIndex = 22;
            this.pxTrackBar.Value = 5;
            this.pxTrackBar.ValueChanged += new System.EventHandler(this.PxTrackBar_ValueChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(41, 498);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 20);
            this.label8.TabIndex = 21;
            this.label8.Text = "Сдвиг (px):";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(45, 429);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Градусов:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 365);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Процентов:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // degreeTrackBar
            // 
            this.degreeTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.degreeTrackBar.LargeChange = 20;
            this.degreeTrackBar.Location = new System.Drawing.Point(0, 453);
            this.degreeTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.degreeTrackBar.Maximum = 360;
            this.degreeTrackBar.Minimum = 1;
            this.degreeTrackBar.Name = "degreeTrackBar";
            this.degreeTrackBar.Size = new System.Drawing.Size(200, 56);
            this.degreeTrackBar.SmallChange = 10;
            this.degreeTrackBar.TabIndex = 18;
            this.degreeTrackBar.Value = 5;
            this.degreeTrackBar.ValueChanged += new System.EventHandler(this.DegreeTrackBar_ValueChanged);
            // 
            // percentageTrackBar
            // 
            this.percentageTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.percentageTrackBar.LargeChange = 10;
            this.percentageTrackBar.Location = new System.Drawing.Point(0, 389);
            this.percentageTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.percentageTrackBar.Maximum = 99;
            this.percentageTrackBar.Minimum = 1;
            this.percentageTrackBar.Name = "percentageTrackBar";
            this.percentageTrackBar.Size = new System.Drawing.Size(200, 56);
            this.percentageTrackBar.SmallChange = 5;
            this.percentageTrackBar.TabIndex = 17;
            this.percentageTrackBar.Value = 5;
            this.percentageTrackBar.ValueChanged += new System.EventHandler(this.PercentageTrackBar_ValueChanged);
            // 
            // plusYScaleButton
            // 
            this.plusYScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusYScaleButton.Location = new System.Drawing.Point(109, 329);
            this.plusYScaleButton.Margin = new System.Windows.Forms.Padding(4);
            this.plusYScaleButton.Name = "plusYScaleButton";
            this.plusYScaleButton.Size = new System.Drawing.Size(80, 31);
            this.plusYScaleButton.TabIndex = 16;
            this.plusYScaleButton.Text = "y: +□%";
            this.plusYScaleButton.UseVisualStyleBackColor = true;
            this.plusYScaleButton.Click += new System.EventHandler(this.PlusYScaleButton_Click);
            // 
            // plusXScaleButton
            // 
            this.plusXScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusXScaleButton.Location = new System.Drawing.Point(11, 329);
            this.plusXScaleButton.Margin = new System.Windows.Forms.Padding(4);
            this.plusXScaleButton.Name = "plusXScaleButton";
            this.plusXScaleButton.Size = new System.Drawing.Size(80, 31);
            this.plusXScaleButton.TabIndex = 15;
            this.plusXScaleButton.Text = "x: +□%";
            this.plusXScaleButton.UseVisualStyleBackColor = true;
            this.plusXScaleButton.Click += new System.EventHandler(this.PlusXScaleButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 305);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Растяжение:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minusYScaleButton
            // 
            this.minusYScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusYScaleButton.Location = new System.Drawing.Point(109, 271);
            this.minusYScaleButton.Margin = new System.Windows.Forms.Padding(4);
            this.minusYScaleButton.Name = "minusYScaleButton";
            this.minusYScaleButton.Size = new System.Drawing.Size(80, 31);
            this.minusYScaleButton.TabIndex = 13;
            this.minusYScaleButton.Text = "y: -□%";
            this.minusYScaleButton.UseVisualStyleBackColor = true;
            this.minusYScaleButton.Click += new System.EventHandler(this.MinusYScaleButton_Click);
            // 
            // minusXScaleButton
            // 
            this.minusXScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusXScaleButton.Location = new System.Drawing.Point(11, 271);
            this.minusXScaleButton.Margin = new System.Windows.Forms.Padding(4);
            this.minusXScaleButton.Name = "minusXScaleButton";
            this.minusXScaleButton.Size = new System.Drawing.Size(80, 31);
            this.minusXScaleButton.TabIndex = 12;
            this.minusXScaleButton.Text = "x: -□%";
            this.minusXScaleButton.UseVisualStyleBackColor = true;
            this.minusXScaleButton.Click += new System.EventHandler(this.MinusXScaleButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 247);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сжатие:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transfYMbutton
            // 
            this.transfYMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfYMbutton.Location = new System.Drawing.Point(109, 213);
            this.transfYMbutton.Margin = new System.Windows.Forms.Padding(4);
            this.transfYMbutton.Name = "transfYMbutton";
            this.transfYMbutton.Size = new System.Drawing.Size(80, 31);
            this.transfYMbutton.TabIndex = 10;
            this.transfYMbutton.Text = "y: -□px";
            this.transfYMbutton.UseVisualStyleBackColor = true;
            this.transfYMbutton.Click += new System.EventHandler(this.TransfYMbutton_Click);
            // 
            // transfYPbutton
            // 
            this.transfYPbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfYPbutton.Location = new System.Drawing.Point(11, 213);
            this.transfYPbutton.Margin = new System.Windows.Forms.Padding(4);
            this.transfYPbutton.Name = "transfYPbutton";
            this.transfYPbutton.Size = new System.Drawing.Size(80, 31);
            this.transfYPbutton.TabIndex = 9;
            this.transfYPbutton.Text = "y: +□px";
            this.transfYPbutton.UseVisualStyleBackColor = true;
            this.transfYPbutton.Click += new System.EventHandler(this.TransfYPbutton_Click);
            // 
            // transfXMbutton
            // 
            this.transfXMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfXMbutton.Location = new System.Drawing.Point(109, 175);
            this.transfXMbutton.Margin = new System.Windows.Forms.Padding(4);
            this.transfXMbutton.Name = "transfXMbutton";
            this.transfXMbutton.Size = new System.Drawing.Size(80, 31);
            this.transfXMbutton.TabIndex = 8;
            this.transfXMbutton.Text = "x: -□px";
            this.transfXMbutton.UseVisualStyleBackColor = true;
            this.transfXMbutton.Click += new System.EventHandler(this.TransfXMbutton_Click);
            // 
            // transfXPbutton
            // 
            this.transfXPbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfXPbutton.Location = new System.Drawing.Point(11, 175);
            this.transfXPbutton.Margin = new System.Windows.Forms.Padding(4);
            this.transfXPbutton.Name = "transfXPbutton";
            this.transfXPbutton.Size = new System.Drawing.Size(80, 31);
            this.transfXPbutton.TabIndex = 7;
            this.transfXPbutton.Text = "x: +□px";
            this.transfXPbutton.UseVisualStyleBackColor = true;
            this.transfXPbutton.Click += new System.EventHandler(this.TransfXPbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Перенос:";
            // 
            // rotateMinusButton
            // 
            this.rotateMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotateMinusButton.Location = new System.Drawing.Point(109, 112);
            this.rotateMinusButton.Margin = new System.Windows.Forms.Padding(4);
            this.rotateMinusButton.Name = "rotateMinusButton";
            this.rotateMinusButton.Size = new System.Drawing.Size(80, 31);
            this.rotateMinusButton.TabIndex = 5;
            this.rotateMinusButton.Text = "-□°";
            this.rotateMinusButton.UseVisualStyleBackColor = true;
            this.rotateMinusButton.Click += new System.EventHandler(this.RotateMinusButton_Click);
            // 
            // rotatePlusButton
            // 
            this.rotatePlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotatePlusButton.Location = new System.Drawing.Point(11, 112);
            this.rotatePlusButton.Margin = new System.Windows.Forms.Padding(4);
            this.rotatePlusButton.Name = "rotatePlusButton";
            this.rotatePlusButton.Size = new System.Drawing.Size(80, 31);
            this.rotatePlusButton.TabIndex = 4;
            this.rotatePlusButton.Text = "+□°";
            this.rotatePlusButton.UseVisualStyleBackColor = true;
            this.rotatePlusButton.Click += new System.EventHandler(this.RotatePlusButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(41, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поворот:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scaleMinusButton
            // 
            this.scaleMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scaleMinusButton.Location = new System.Drawing.Point(109, 54);
            this.scaleMinusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scaleMinusButton.Name = "scaleMinusButton";
            this.scaleMinusButton.Size = new System.Drawing.Size(80, 31);
            this.scaleMinusButton.TabIndex = 2;
            this.scaleMinusButton.Text = "-□%";
            this.scaleMinusButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scaleMinusButton.UseVisualStyleBackColor = true;
            this.scaleMinusButton.Click += new System.EventHandler(this.ScaleMinusButton_Click);
            // 
            // scalePlusButton
            // 
            this.scalePlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scalePlusButton.Location = new System.Drawing.Point(11, 54);
            this.scalePlusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.scalePlusButton.Name = "scalePlusButton";
            this.scalePlusButton.Size = new System.Drawing.Size(80, 31);
            this.scalePlusButton.TabIndex = 1;
            this.scalePlusButton.Text = "+□%";
            this.scalePlusButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scalePlusButton.UseVisualStyleBackColor = true;
            this.scalePlusButton.Click += new System.EventHandler(this.ScalePlusButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Масштабирование:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imagePanel
            // 
            this.imagePanel.AutoSize = true;
            this.imagePanel.Controls.Add(this.pictureBox);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePanel.Location = new System.Drawing.Point(0, 30);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(1067, 738);
            this.imagePanel.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1067, 738);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // degreeLabel
            // 
            this.degreeLabel.AutoSize = true;
            this.degreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.degreeLabel.Location = new System.Drawing.Point(153, 430);
            this.degreeLabel.Name = "degreeLabel";
            this.degreeLabel.Size = new System.Drawing.Size(17, 18);
            this.degreeLabel.TabIndex = 24;
            this.degreeLabel.Text = "5";
            // 
            // pxLabel
            // 
            this.pxLabel.AutoSize = true;
            this.pxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pxLabel.Location = new System.Drawing.Point(153, 500);
            this.pxLabel.Name = "pxLabel";
            this.pxLabel.Size = new System.Drawing.Size(17, 18);
            this.pxLabel.TabIndex = 25;
            this.pxLabel.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 768);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.degreeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.percentageTrackBar)).EndInit();
            this.imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button scaleMinusButton;
        private System.Windows.Forms.Button scalePlusButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rotatePlusButton;
        private System.Windows.Forms.Button rotateMinusButton;
        private System.Windows.Forms.Button transfYMbutton;
        private System.Windows.Forms.Button transfYPbutton;
        private System.Windows.Forms.Button transfXMbutton;
        private System.Windows.Forms.Button transfXPbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plusYScaleButton;
        private System.Windows.Forms.Button plusXScaleButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button minusYScaleButton;
        private System.Windows.Forms.Button minusXScaleButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar percentageTrackBar;
        private System.Windows.Forms.TrackBar pxTrackBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar degreeTrackBar;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Label pxLabel;
        private System.Windows.Forms.Label degreeLabel;
    }
}

