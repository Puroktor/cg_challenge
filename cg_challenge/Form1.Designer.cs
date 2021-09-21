
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel.SuspendLayout();
            this.imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openButton});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(98, 20);
            this.openButton.Text = "Открыть файл";
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel.Controls.Add(this.textBox1);
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
            this.panel.Location = new System.Drawing.Point(450, 24);
            this.panel.Margin = new System.Windows.Forms.Padding(2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(150, 342);
            this.panel.TabIndex = 2;
            // 
            // plusYScaleButton
            // 
            this.plusYScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusYScaleButton.Location = new System.Drawing.Point(82, 267);
            this.plusYScaleButton.Name = "plusYScaleButton";
            this.plusYScaleButton.Size = new System.Drawing.Size(60, 25);
            this.plusYScaleButton.TabIndex = 16;
            this.plusYScaleButton.Text = "y: +5%";
            this.plusYScaleButton.UseVisualStyleBackColor = true;
            this.plusYScaleButton.Click += new System.EventHandler(this.PlusYScaleButton_Click);
            // 
            // plusXScaleButton
            // 
            this.plusXScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plusXScaleButton.Location = new System.Drawing.Point(8, 267);
            this.plusXScaleButton.Name = "plusXScaleButton";
            this.plusXScaleButton.Size = new System.Drawing.Size(60, 25);
            this.plusXScaleButton.TabIndex = 15;
            this.plusXScaleButton.Text = "x: +5%";
            this.plusXScaleButton.UseVisualStyleBackColor = true;
            this.plusXScaleButton.Click += new System.EventHandler(this.PlusXScaleButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(21, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Растяжение:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // minusYScaleButton
            // 
            this.minusYScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusYScaleButton.Location = new System.Drawing.Point(82, 220);
            this.minusYScaleButton.Name = "minusYScaleButton";
            this.minusYScaleButton.Size = new System.Drawing.Size(60, 25);
            this.minusYScaleButton.TabIndex = 13;
            this.minusYScaleButton.Text = "y: -5%";
            this.minusYScaleButton.UseVisualStyleBackColor = true;
            this.minusYScaleButton.Click += new System.EventHandler(this.MinusYScaleButton_Click);
            // 
            // minusXScaleButton
            // 
            this.minusXScaleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minusXScaleButton.Location = new System.Drawing.Point(8, 220);
            this.minusXScaleButton.Name = "minusXScaleButton";
            this.minusXScaleButton.Size = new System.Drawing.Size(60, 25);
            this.minusXScaleButton.TabIndex = 12;
            this.minusXScaleButton.Text = "x: -5%";
            this.minusXScaleButton.UseVisualStyleBackColor = true;
            this.minusXScaleButton.Click += new System.EventHandler(this.MinusXScaleButton_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(34, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Сжатие:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // transfYMbutton
            // 
            this.transfYMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfYMbutton.Location = new System.Drawing.Point(82, 173);
            this.transfYMbutton.Name = "transfYMbutton";
            this.transfYMbutton.Size = new System.Drawing.Size(60, 25);
            this.transfYMbutton.TabIndex = 10;
            this.transfYMbutton.Text = "y: -5px";
            this.transfYMbutton.UseVisualStyleBackColor = true;
            this.transfYMbutton.Click += new System.EventHandler(this.TransfYMbutton_Click);
            // 
            // transfYPbutton
            // 
            this.transfYPbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfYPbutton.Location = new System.Drawing.Point(8, 173);
            this.transfYPbutton.Name = "transfYPbutton";
            this.transfYPbutton.Size = new System.Drawing.Size(60, 25);
            this.transfYPbutton.TabIndex = 9;
            this.transfYPbutton.Text = "y: +5px";
            this.transfYPbutton.UseVisualStyleBackColor = true;
            this.transfYPbutton.Click += new System.EventHandler(this.TransfYPbutton_Click);
            // 
            // transfXMbutton
            // 
            this.transfXMbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfXMbutton.Location = new System.Drawing.Point(82, 142);
            this.transfXMbutton.Name = "transfXMbutton";
            this.transfXMbutton.Size = new System.Drawing.Size(60, 25);
            this.transfXMbutton.TabIndex = 8;
            this.transfXMbutton.Text = "x: -5px";
            this.transfXMbutton.UseVisualStyleBackColor = true;
            this.transfXMbutton.Click += new System.EventHandler(this.TransfXMbutton_Click);
            // 
            // transfXPbutton
            // 
            this.transfXPbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.transfXPbutton.Location = new System.Drawing.Point(8, 142);
            this.transfXPbutton.Name = "transfXPbutton";
            this.transfXPbutton.Size = new System.Drawing.Size(60, 25);
            this.transfXPbutton.TabIndex = 7;
            this.transfXPbutton.Text = "x: +5px";
            this.transfXPbutton.UseVisualStyleBackColor = true;
            this.transfXPbutton.Click += new System.EventHandler(this.TransfXPbutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Перенос:";
            // 
            // rotateMinusButton
            // 
            this.rotateMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotateMinusButton.Location = new System.Drawing.Point(82, 91);
            this.rotateMinusButton.Name = "rotateMinusButton";
            this.rotateMinusButton.Size = new System.Drawing.Size(60, 25);
            this.rotateMinusButton.TabIndex = 5;
            this.rotateMinusButton.Text = "-5°";
            this.rotateMinusButton.UseVisualStyleBackColor = true;
            this.rotateMinusButton.Click += new System.EventHandler(this.RotateMinusButton_Click);
            // 
            // rotatePlusButton
            // 
            this.rotatePlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rotatePlusButton.Location = new System.Drawing.Point(8, 91);
            this.rotatePlusButton.Name = "rotatePlusButton";
            this.rotatePlusButton.Size = new System.Drawing.Size(60, 25);
            this.rotatePlusButton.TabIndex = 4;
            this.rotatePlusButton.Text = "+5°";
            this.rotatePlusButton.UseVisualStyleBackColor = true;
            this.rotatePlusButton.Click += new System.EventHandler(this.RotatePlusButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Поворот:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scaleMinusButton
            // 
            this.scaleMinusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scaleMinusButton.Location = new System.Drawing.Point(82, 44);
            this.scaleMinusButton.Margin = new System.Windows.Forms.Padding(2);
            this.scaleMinusButton.Name = "scaleMinusButton";
            this.scaleMinusButton.Size = new System.Drawing.Size(60, 25);
            this.scaleMinusButton.TabIndex = 2;
            this.scaleMinusButton.Text = "-5%";
            this.scaleMinusButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scaleMinusButton.UseVisualStyleBackColor = true;
            this.scaleMinusButton.Click += new System.EventHandler(this.ScaleMinusButton_Click);
            // 
            // scalePlusButton
            // 
            this.scalePlusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.scalePlusButton.Location = new System.Drawing.Point(8, 44);
            this.scalePlusButton.Margin = new System.Windows.Forms.Padding(2);
            this.scalePlusButton.Name = "scalePlusButton";
            this.scalePlusButton.Size = new System.Drawing.Size(60, 25);
            this.scalePlusButton.TabIndex = 1;
            this.scalePlusButton.Text = "+5%";
            this.scalePlusButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.scalePlusButton.UseVisualStyleBackColor = true;
            this.scalePlusButton.Click += new System.EventHandler(this.ScalePlusButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Масштабирование:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imagePanel
            // 
            this.imagePanel.AutoSize = true;
            this.imagePanel.Controls.Add(this.pictureBox);
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imagePanel.Location = new System.Drawing.Point(0, 24);
            this.imagePanel.Margin = new System.Windows.Forms.Padding(2);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(450, 342);
            this.imagePanel.TabIndex = 3;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(450, 342);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.imagePanel);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
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
        private System.Windows.Forms.TextBox textBox1;
    }
}

