using System;

namespace Generic_example
{
    class Program
    {
        public class Product<A>
        {
            public A ID;
            public void setID(A _ID) {
                this.ID = _ID;
            }
            public void PrintInfo() {
                Console.WriteLine($"ID={this.ID}");
            }
        }
        static void Main(string[] args)
        {
            Product<int> sanpham1= new Product<int>();
            sanpham1.setID(123);
            sanpham1.PrintInfo();
            List<int> list1= new List<int>();

            Product<string> sanpham2 = new Product<string>();
            sanpham2.setID("hieucute");
            sanpham2.PrintInfo();
            

        }
    }
}