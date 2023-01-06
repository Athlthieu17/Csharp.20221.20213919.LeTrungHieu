namespace ThreadGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Demo);
            thread.IsBackground = true;
            thread.Start();
        }

        void Demo()
        {
            for (int i = 0; i < Convert.ToInt32(textBox1.Text); i++)
            {
                label1.Text = i.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hieucuyte");
        }

        int speed = 100;

        void movePictureBox()
        {
            new Thread(
                () =>
                {
                    while (true)
                    {
                        if (checkBox1.Checked)
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X - 1, pictureBox1.Location.Y);
                        }

                        else
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X + 1, pictureBox1.Location.Y);
                        }
                        Thread.Sleep(speed);
                    }
                }) { IsBackground = true }.Start();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            movePictureBox();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out speed))
            {

            }
        }
    }
}