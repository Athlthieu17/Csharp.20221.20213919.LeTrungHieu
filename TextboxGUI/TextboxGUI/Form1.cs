using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextboxGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;
            if (Int32.TryParse(txbValue.Text, out num))
                lbValue.Text = (num * num).ToString();
            else
                lbValue.Text = "Error";
        }

        private void txbValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
