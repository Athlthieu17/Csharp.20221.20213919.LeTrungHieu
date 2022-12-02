using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageGUI
{
    public partial class Form1 : Form
    {
        string extention = ".jpg";
        public Form1()
        {
            InitializeComponent();

            loadImageName();


        }


        void loadImageName()
        {
            List<string> listImage = new List<string>() { "1", "2" , "3" , "4" };
            cbImage.DataSource = listImage;
        }

        private void cbImage_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedValue != null)
            {
                Bitmap bm = new Bitmap(Application.StartupPath + "\\Resources\\" +cb.SelectedValue.ToString() +extention);
                pictureBox1.Image = bm;
            }
        }
    }
}
