using System;
using System.Collections.Generic;

namespace ListExample
{
    class Product 
    {
        public string Name {set; get;}
        public double Price {set; get;}
        public int Id {set; get;}
        public string Origin {set; get;}

    }
    class Program
    {
        //List
        static void Main(string[] args)
        {
        //     List<int> ds1 = new List<int>() {7,8,9};

        //     ds1.Add(1);
        //     ds1.Add(1);
        //     ds1.AddRange(new int[] {3,4,5});

        //     Console.WriteLine(ds1.Count);
        //     Console.WriteLine(ds1[1]);
        //     ds1.Insert(0, 10); // them phan tu 10 o vi tri 0

        //     ds1.RemoveAt(2); // xoa phan tu thu 2   
        //     ds1.Remove(8); //xoa phan tu 8

        //     foreach (int n in ds1)
        //     {
        //         Console.WriteLine(n);
        //     }
        //     var n = ds1.Find(
        //         (e) => {
        //             return e %2 ==0;
        //         }
        //     ); 
        //     // tim kiem phan tu dau tien tim thay theo dieu kien delegate
        //     Console.WriteLine(n);

        //     var list_n = ds1.FindAll(
        //         (e) => {
        //             return e >5 ;
        //         }
        //     );
        //     //  tra ve danh sach tat ca cac phan tu thoa man dieu kien delegate
        //     foreach (int i in list_n)
        //     {
        //         Console.WriteLine(i);
        //     }

        //     List<string> ds2;

        //     List<Product> products = new List<Product>() {
        //         new Product() {
        //             Name = "Iphone X", Price = 1000 , Origin = "China", Id=1
        //         },
        //         new Product() {
        //             Name = "Samsung", Price = 900 , Origin = "China", Id=2
        //         },
        //         new Product() {
        //             Name = "Sony", Price = 1100 , Origin = "Japan", Id=3
        //         },
        //         new Product() {
        //             Name = "Nokia", Price = 800 , Origin = "China", Id=4
        //         }
        //     };

        //     // Japan

        //     var p = products.Find(
        //         (p) => {
        //             return p.Origin == "Japan";
        //         }
        //     );
        //     if (p != null) 
        //     {
        //         Console.WriteLine($"{p.Name} - {p.Price} - {p.Origin} - {p.Id}");
        //     }

        //     products.Sort(
        //         (p1, p2) => {
        //             // return 0 if p1 == p2
        //             // return 1 if p1 > p2
        //             // return -1 if p1 < p2
        //             if (p1.Price == p2.Price) return 0;
        //             if (p1.Price < p2.Price) return 1;
        //             return -1;

        //         }
        //     );

        //     foreach (var _products in products)
        //     {
        //         Console.WriteLine($"{_products.Name} - {_products.Price} - {_products.Origin}");;
        //     }
        // }

        SortedList<string, Product> products = new SortedList<string, Product>();
        products["SanPham1"] = new Product() {Name = "Iphone X", Price = 1000 , Origin = "China"};
        products["SanPham2"] = new Product() {Name = "Iphone X", Price = 1000 , Origin = "China"};
        products.Add("SanPham3", new Product() {Name = "Nokia", Price = 1000 , Origin = "China"});

        var p = products["SanPham2"];
        Console.WriteLine(p.Name);
        var keys= products.Keys;

        foreach (var _keys in keys)
        {
            var product = products[_keys];
            Console.WriteLine(product.Name);
        }

        foreach (KeyValuePair<string, Product> item in products)
        {
            var key = item.Key;
            var val = item.Value;
            Console.WriteLine($"{key} - {val.Name}");
        }
    }
}
}