using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinQGUI
{
    public partial class Form1 : Form
    {
        List<Food> foodList;
        public Form1()
        {
            InitializeComponent();
            LoadFood();
        }

        void LoadFood()
        {
            foodList = new List<Food>();
            foodList.Add(new Food("Dú dê nướng", "55555"));
            foodList.Add(new Food("Mực một nắng nướng muối ớt", "999999"));
            foodList.Add(new Food("Ếch núp nùm", "333333"));
            foodList.Add(new Food("cái gì đây", "1"));
            foodList.Add(new Food("7up", "15000"));
            foodList.Add(new Food("Ốc mỡ cháy tỏi", "50000"));

            cbData.DataSource = foodList;
            cbData.DisplayMember = "Name";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<Food> result = new List<Food>();

            //foreach (Food item in foodList)
            //{
            //    if (item.Name == txbKey.Text)
            //    {
            //        result.Add(item);
            //    }
            //}

            //result = foodList.Where(p => p.Name == txbKey.Text).ToList();
            //var result2 = foodList.Select(p=>p.Price).SingleOrDefault();

            //result = foodList.Skip(2).Take(2).ToList();
            result = foodList.OrderBy(p => Convert.ToInt32(p.Price)).ToList();

            cbResult.DataSource = result;
            cbResult.DisplayMember = "Name";
        }
    }

    public class Food
    {
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Food() { }

        public Food(string name, string price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
