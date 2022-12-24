using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            
            btn.Text = "adath";
            btn.AutoSize = true;
            Random rnd = new Random();
            btn.Location = new Point(rnd.Next(0, panelButton.Size.Width), rnd.Next(0, panelButton.Size.Height));
            panelButton.Controls.Add(btn);
            flowLayoutPanelButton.Controls.Add(btn); // uu tien add btn vao flow nay neu add cùng luc
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelButton.Enabled = !panelButton.Enabled;
        }
    }
}
