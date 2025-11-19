namespace Slå_Flugan
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer waspPlayer =
    new System.Media.SoundPlayer(Properties.Resources.wasp);

        System.Media.SoundPlayer punchPlayer =
    new System.Media.SoundPlayer(Properties.Resources.punch);
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            geting.Visible = false;
            punchPlayer.Play();
            timer1.Stop();
            MessageBox.Show("Grattis! du fick getingen!");
            button1.Visible = true;
            button2.Visible = true;
            timer3.Stop();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            geting.Top = Random.Shared.Next(100, 300);
            geting.Left = Random.Shared.Next(0, 600);
            geting.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            geting.Visible = true;
            timer3.Start();
            timer1.Start();
            button1.Visible = false;
            button2.Visible = false;
            waspPlayer.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            geting1.Visible = true;
            geting2.Visible = true;
            geting3.Visible = true;
            geting4.Visible = true;
            geting5.Visible = true;
            geting6.Visible = true;
            timer3.Start();
            timer2.Start();
            button1.Visible = false;
            button2.Visible = false;
            waspPlayer.Play();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            geting1.Top = Random.Shared.Next(100, 300);
            geting1.Left = Random.Shared.Next(0, 600);
            geting1.BringToFront();

            geting2.Top = Random.Shared.Next(100, 300);
            geting2.Left = Random.Shared.Next(0, 600);
            geting2.BringToFront();

            geting3.Top = Random.Shared.Next(100, 300);
            geting3.Left = Random.Shared.Next(0, 600);
            geting3.BringToFront();

            geting4.Top = Random.Shared.Next(100, 300);
            geting4.Left = Random.Shared.Next(0, 600);
            geting4.BringToFront();

            geting5.Top = Random.Shared.Next(100, 300);
            geting5.Left = Random.Shared.Next(0, 600);
            geting5.BringToFront();

            geting6.Top = Random.Shared.Next(100, 300);
            geting6.Left = Random.Shared.Next(0, 600);
            geting6.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            geting2.Visible = false;
            check();
            punchPlayer.Play();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            geting4.Visible = false;
            check();
            punchPlayer.Play();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            geting1.Visible = false;
            check();
            punchPlayer.Play();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            geting5.Visible = false;
            check();
            punchPlayer.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            geting3.Visible = false;
            check();
            punchPlayer.Play();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            geting6.Visible = false;
            check();
            punchPlayer.Play();
        }
        private void check()
        {
            if (geting1.Visible == false && geting2.Visible == false && geting3.Visible == false && geting4.Visible == false && geting5.Visible == false && geting5.Visible == false)
            {
                timer3.Stop();
                timer2.Stop();
                MessageBox.Show("Grattis! du fick getingen!");
                button1.Visible = true;
                button2.Visible = true;
            }

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            waspPlayer.Play();
        }
    }
}
