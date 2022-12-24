using Microsoft.Win32;

namespace ListViewGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadListView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        ImageList imgListSmall;
        ImageList imgListLarge;

        void loadImageList()
        {
            imgListLarge = new ImageList() { ImageSize = new Size(68,68)};
            imgListLarge.Images.Add(new Bitmap(@"C:\Users\W10.TQ\LearningCS\ListViewGUI\ListViewGUI\Image\1.jpg"));
            imgListLarge.Images.Add(new Bitmap(@"C:\Users\W10.TQ\LearningCS\ListViewGUI\ListViewGUI\Image\2.jpg"));
            imgListLarge.Images.Add(new Bitmap(@"C:\Users\W10.TQ\LearningCS\ListViewGUI\ListViewGUI\Image\3.png"));


            imgListSmall = new ImageList() { ImageSize = new Size(16, 16) };
            imgListSmall.Images.Add(new Bitmap(@"C:\Users\W10.TQ\LearningCS\ListViewGUI\ListViewGUI\Image\1.jpg"));
            imgListSmall.Images.Add(new Bitmap(@"C:\Users\W10.TQ\LearningCS\ListViewGUI\ListViewGUI\Image\2.jpg"));
            imgListSmall.Images.Add(new Bitmap(@"C:\Users\W10.TQ\LearningCS\ListViewGUI\ListViewGUI\Image\3.png"));
        }
        void LoadListView()
        {
            loadImageList();


            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.LargeImageList = imgListLarge;
            listView1.SmallImageList = imgListSmall;

            listView1.Columns.Add("Column 1");
            listView1.Columns.Add("Column 2");
            listView1.Columns.Add("Column 3");


            ListViewItem item1 = new ListViewItem();
            item1.Text = "Item 1";
            item1.ImageIndex = 0;
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1" });
            item1.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 1.2" });




            ListViewItem item2 = new ListViewItem();
            item2.Text = "Item 2";
            item2.ImageIndex = 1;

            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2" });
            item2.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 2.2" });


            ListViewItem item3 = new ListViewItem();
            item3.Text = "Item 3";
            item3.ImageIndex = 2;
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 3" });
            item3.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = "Sub item 3.2" });


            listView1.Items.Add(item1);
            listView1.Items.Add(item2);
            listView1.Items.Add(item3);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.CheckBoxes = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lsv = sender as ListView;
            
            if(lsv.SelectedItems.Count > 0)
            {
                foreach(ListViewItem item in lsv.SelectedItems)
                {
                    MessageBox.Show(item.Text);
                }
                
            }
        }
    }
}