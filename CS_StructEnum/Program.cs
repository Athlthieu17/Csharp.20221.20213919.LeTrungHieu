using System;
using System.Text;
namespace CS_StructEnum 
{
    class Program 
    {
        //struct
        public struct Product {
            //du lieu
            public string name;

            public double price;
            //phuong thuc
            public string Info {
                get {
                    return $"{name},{price}";
                }
            }
            public string GetInfo()
            {
                return $"Ten san pham :{name}, gia: {price}";
            }

            //constructor

            public Product(string _name, double _price) 
            {
                name = _name; 
                this.price = _price;

            }
        }

        // kiểu liệt kê Enum
        
        

        static void Main(string[] args) 
        {
            // Product sanpham1;
            // sanpham1.name = "Iphone";
            // sanpham1.price = 1000;

            // Console.WriteLine(sanpham1.GetInfo());
            
            // Product sanpham2 = new Product("Nokia",900);
            // Console.WriteLine(sanpham2.GetInfo());
            // Console.WriteLine(sanpham2.Info);


        }


    }
}