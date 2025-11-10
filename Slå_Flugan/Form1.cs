namespace Slå_Flugan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Grattis! du fick getingen!");
            button1.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            geting.Top = Random.Shared.Next(100, 300);
            geting.Left = Random.Shared.Next(0, 600);
            geting.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button1.Visible = false;
        }
    }
}
