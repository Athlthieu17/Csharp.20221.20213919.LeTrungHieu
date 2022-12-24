using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MesssageBoxGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("content","Caption",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Hand,MessageBoxDefaultButton.Button2
                ,MessageBoxOptions.ServiceNotification);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("GoodLuck!");
            }
            else
            {
                MessageBox.Show("No out!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
