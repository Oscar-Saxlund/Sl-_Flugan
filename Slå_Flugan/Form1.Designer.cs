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
            ((System.ComponentModel.ISupportInitialize)geting).BeginInit();
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
            geting.Click += pictureBox1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(334, 22);
            button1.Name = "button1";
            button1.Size = new Size(135, 49);
            button1.TabIndex = 1;
            button1.Text = "PLAY";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Skärmbild_2025_11_10_152530;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(geting);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)geting).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox geting;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
    }
}
