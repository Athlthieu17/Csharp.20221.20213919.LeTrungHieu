using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void showResult(Label label,Panel panel)
        {
            RadioButton checkBox = null;

            foreach(RadioButton item in panel.Controls)
            {
                if(item!=null)
                {
                    if (item.Checked)
                    {
                        checkBox = item;
                        break;
                    }
                }
                
            }
            if (checkBox != null) label.Text = checkBox.Text;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            showResult(label1, panel1);
            showResult(label2, panel2);
            showResult(label3, panel3);



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked)
            {
                label1.Text = radioButton.Text;
            }
        }
    }
}
