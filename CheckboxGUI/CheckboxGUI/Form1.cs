using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckboxGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Click");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("CheckedChanged");

        }


        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {

            //MessageBox.Show("CheckStateChanged");
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string man = checkBoxMan.CheckState == CheckState.Checked ? "are a" : checkBoxMan.CheckState == CheckState.Checked ? "are not a" 
                : "nope";
            string showString = string.Format("Hello {0}, you {1} man",name,man);
            MessageBox.Show(showString);
        }
    }
}
