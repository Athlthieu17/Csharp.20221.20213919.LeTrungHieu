namespace Product
{
    public partial class Product 
    {
        public string description {set; get;}

        public Manufactory manufactory{set;get;}
        public class Manufactory 
        {
            public string name {set;get;}
            public string addr {set;get;}
            
        }
    }
}