﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Label
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Djokovicth1";
            Form2 f = new Form2();
            f.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            label1.Text = "Djokovicth";

            
        }
    }
}
