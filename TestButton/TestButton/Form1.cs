using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        void addButton()
        {
            Random rand = new Random();
            Button btn = new Button() { Text = i.ToString(), Location = new Point(rand.Next(0,this.Size.Width), rand.Next(0, this.Size.Height)) };
            btn.Click += Btn_Click;

            this.Controls.Add(btn); 
            i++;
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addButton();
        }
    }
}
