using System;
using MyNameSpace;
using MyNameSpace.Abc;

namespace Ns_example 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class1.XinChao();
            // Class2.XinChao();
            Product.Product sanpham = new Product.Product();
            sanpham.name = "Ipad";
            sanpham.price = 1000; 
            sanpham.description = "Day la Ipad";
            sanpham.manufactory = new Product.Product.Manufactory();
            sanpham.manufactory.name = "Apple";
            sanpham.manufactory.addr = "China";
            Console.WriteLine(sanpham.GetInfo());
        }
    }
}