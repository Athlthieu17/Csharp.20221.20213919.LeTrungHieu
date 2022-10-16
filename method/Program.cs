using System;

namespace Method 
{
    class Program
    {
        //virtual method
        //abstract là lớp trừu tượng
        class Product 
        {
            protected double Price{set;get;}

            // bonous the virtual to pressure layer
            public virtual void  ProductInfo()
            {
                Console.WriteLine($"Gia sam pham: {Price}");
            }
            public void Test() => ProductInfo();
            
        }

        class Iphone : Product 
        {
            public Iphone() => Price =500;

            //bonous the override to press
            public override void ProductInfo() 
            {
                Console.WriteLine("Dien thoai Iphone");
                base.ProductInfo(); //Truy cap vao lop duoc ke thua
            }

            
        }

        //interface

        interface IHinhHoc 
        {
            public double TinhChuVi();

            public double TinhDienTich();
        }

        class HinhChuNhat : IHinhHoc
        {
            public HinhChuNhat(double _a,double _b)
            {
                a = _a;
                b = _b;
            }
            public double a {set;get;}
            public double b {set;get;}

            public IHinhHoc.TinhChuVi()
            {
                throw new NotImplementedException();
            }

            public IHinhHoc.TinhDienTich()
            {
                throw new NotImplementedException();
            }
        }
        static void Main(string[] args)
        {
            // Iphone i = new Iphone();
            // i.Test();
        }
    }
}