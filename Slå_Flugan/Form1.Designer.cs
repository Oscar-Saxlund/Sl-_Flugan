namespace Slå_Flugan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            geting = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            geting1 = new PictureBox();
            geting2 = new PictureBox();
            geting3 = new PictureBox();
            geting4 = new PictureBox();
            geting5 = new PictureBox();
            geting6 = new PictureBox();
            timer2 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)geting).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geting1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geting2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geting3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geting4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geting5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geting6).BeginInit();
            SuspendLayout();
            // 
            // geting
            // 
            geting.BackColor = Color.Transparent;
            geting.Image = Properties.Resources.geting2;
            geting.Location = new Point(55, 129);
            geting.Name = "geting";
            geting.Size = new Size(90, 91);
            geting.SizeMode = PictureBoxSizeMode.StretchImage;
            geting.TabIndex = 0;
            geting.TabStop = false;
            geting.Visible = false;
            geting.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(276, 2);
            button1.Name = "button1";
            button1.Size = new Size(117, 63);
            button1.TabIndex = 1;
            button1.Text = "Easy mode";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(416, 2);
            button2.Name = "button2";
            button2.Size = new Size(117, 63);
            button2.TabIndex = 2;
            button2.Text = "Hard Mode";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // geting1
            // 
            geting1.BackColor = Color.Transparent;
            geting1.Image = Properties.Resources.geting2;
            geting1.Location = new Point(366, 141);
            geting1.Name = "geting1";
            geting1.Size = new Size(90, 91);
            geting1.SizeMode = PictureBoxSizeMode.StretchImage;
            geting1.TabIndex = 3;
            geting1.TabStop = false;
            geting1.Visible = false;
            geting1.Click += pictureBox1_Click_1;
            // 
            // geting2
            // 
            geting2.BackColor = Color.Transparent;
            geting2.Image = Properties.Resources.geting2;
            geting2.Location = new Point(128, 286);
            geting2.Name = "geting2";
            geting2.Size = new Size(90, 91);
            geting2.SizeMode = PictureBoxSizeMode.StretchImage;
            geting2.TabIndex = 4;
            geting2.TabStop = false;
            geting2.Visible = false;
            geting2.Click += pictureBox2_Click;
            // 
            // geting3
            // 
            geting3.BackColor = Color.Transparent;
            geting3.Image = Properties.Resources.geting2;
            geting3.Location = new Point(575, 252);
            geting3.Name = "geting3";
            geting3.Size = new Size(90, 91);
            geting3.SizeMode = PictureBoxSizeMode.StretchImage;
            geting3.TabIndex = 5;
            geting3.TabStop = false;
            geting3.Visible = false;
            geting3.Click += pictureBox3_Click;
            // 
            // geting4
            // 
            geting4.BackColor = Color.Transparent;
            geting4.Image = Properties.Resources.geting2;
            geting4.Location = new Point(211, 83);
            geting4.Name = "geting4";
            geting4.Size = new Size(90, 91);
            geting4.SizeMode = PictureBoxSizeMode.StretchImage;
            geting4.TabIndex = 6;
            geting4.TabStop = false;
            geting4.Visible = false;
            geting4.Click += pictureBox4_Click;
            // 
            // geting5
            // 
            geting5.BackColor = Color.Transparent;
            geting5.Image = Properties.Resources.geting2;
            geting5.Location = new Point(430, 304);
            geting5.Name = "geting5";
            geting5.Size = new Size(90, 91);
            geting5.SizeMode = PictureBoxSizeMode.StretchImage;
            geting5.TabIndex = 7;
            geting5.TabStop = false;
            geting5.Visible = false;
            geting5.Click += pictureBox5_Click;
            // 
            // geting6
            // 
            geting6.BackColor = Color.Transparent;
            geting6.Image = Properties.Resources.geting2;
            geting6.Location = new Point(613, 71);
            geting6.Name = "geting6";
            geting6.Size = new Size(90, 91);
            geting6.SizeMode = PictureBoxSizeMode.StretchImage;
            geting6.TabIndex = 8;
            geting6.TabStop = false;
            geting6.Visible = false;
            geting6.Click += pictureBox6_Click;
            // 
            // timer2
            // 
            timer2.Interval = 500;
            timer2.Tick += timer2_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Skärmbild_2025_11_10_152530;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(geting6);
            Controls.Add(geting5);
            Controls.Add(geting4);
            Controls.Add(geting3);
            Controls.Add(geting2);
            Controls.Add(geting1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(geting);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)geting).EndInit();
            ((System.ComponentModel.ISupportInitialize)geting1).EndInit();
            ((System.ComponentModel.ISupportInitialize)geting2).EndInit();
            ((System.ComponentModel.ISupportInitialize)geting3).EndInit();
            ((System.ComponentModel.ISupportInitialize)geting4).EndInit();
            ((System.ComponentModel.ISupportInitialize)geting5).EndInit();
            ((System.ComponentModel.ISupportInitialize)geting6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox geting;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private PictureBox geting1;
        private PictureBox geting2;
        private PictureBox geting3;
        private PictureBox geting4;
        private PictureBox geting5;
        private PictureBox geting6;
        private System.Windows.Forms.Timer timer2;
    }
}
