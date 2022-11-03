using System;
using System.Linq;
using System.Collections.Generic;

        // LINQ (Language Intergrated Query) :Ngon ngu truy van tich hop
        // SQL
        // Nguon du lieu : IEnumerable , IEnumerable<T> (Array, List, Stack, Queue, ..)
        //                  XML, SQL
namespace LinQExample
{
    public class Product 
{
    public int ID {set; get;}
    public string Name {set; get;}  
    public double Price {set; get;}    
    public string[] Colors {set; get;}
    public int Brand {set; get;} 
    public Product(int id, string name, double price, string[] colors, int brand)
    {
        ID = id; Name = name; Price = price; Colors = colors; Brand = brand;
    }
    override public string ToString()
            => $"{ID,3} {Name, 12} {Price, 5} {Brand, 2} {string.Join(",", Colors)}";
        }
    public class Brand
    {
        public string Name {set;get;}
        public int ID {set;get;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Product p =new Product(1,"Abc",100 ,new string[] {"xanh","do"} ,2);
            // Console.WriteLine(p);
            Console.OutputEncoding  = System.Text.Encoding.UTF8;
            var brands = new List<Brand>()
            {
                new Brand{ID = 1, Name = "Cong ty AAA"},
                new Brand{ID = 2, Name = "Cong ty AEF"},
                new Brand{ID = 4, Name = "Cong ty ABC"},
            };
            var products = new List<Product>()
            {
                new Product(1, "Bàn trà",    400, new string[] {"Xám", "Xanh"},         2),
                new Product(2, "Tranh treo", 400, new string[] {"Vàng", "Xanh"},        1),
                new Product(3, "Đèn trùm",   500, new string[] {"Trắng"},               3),
                new Product(4, "Bàn học",    200, new string[] {"Trắng", "Xanh"},       1),
                new Product(5, "Túi da",     300, new string[] {"Đỏ", "Đen", "Vàng"},   2),
                new Product(6, "Giường ngủ", 500, new string[] {"Trắng"},               2),
                new Product(7, "Tủ áo",      600, new string[] {"Trắng"},               3),

            };
                // // Lay san pham gia 400
                // var query = from p in products 
                //             where p.Price == 400
                //             select p;
                // foreach (var product in query)
                // {
                //     Console.WriteLine(product);
                // }

                // Select
                var result = products.Select(
                    (p) => {
                        return new {
                            Ten = p.Name,
                            Gia = p.Price
                        };
                    }
                );
                
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                // Where
                var kq = products.Where(
                    (p) => {
                        return p.Price >= 200 && p.Price <=300;
                    }
                );
                foreach (var results in kq)
                {
                    Console.WriteLine(results);
                }
                // SelectMany
                var kq2 = products.SelectMany(
                  (p) => {
                    return p.Colors;
                  }  
                );
                foreach (var results in kq2)
                {
                    Console.WriteLine(results);
                }
                // Min, Max , Sum , Average
                int[] numbers = {1,2,3,4,5,6};
                Console.WriteLine(numbers.Where(n=> n%2 ==0).Max());
                Console.WriteLine(products.Min(p => p.Price ));

                var Result = products.Join(brands , p => p.Brand, b => b.ID,(p,b)=>{
                    return new {
                        Ten = p.Name,
                        ThuongHieu = b.Name
                    };
                });
                foreach (var item in Result)
                {
                    Console.WriteLine(item);
                }
                //GroupJoin

                var result_1 = brands.GroupJoin(products, b => b.ID, p => p.Brand, 
                (brand, pros) => {
                    return new {
                        Thuonghieu = brand.Name,
                        CacSanpham = pros
                    };
                }
                );
                foreach (var gr in result_1)
                {
                    Console.WriteLine(gr.Thuonghieu);
                    foreach (var p in gr.CacSanpham)
                    {
                        Console.WriteLine(p);
                    }
                }

                //Take

                products.Take(4).ToList().ForEach(p => Console.WriteLine(p));
                
                // Skip

                products.Skip(4).ToList().ForEach(p => Console.WriteLine(p));

                // OrderBy (tang dan) // OrderByDescending (giam dan)
                products.OrderBy(p => p.Price).ToList().ForEach( p => Console.WriteLine(p));
                products.OrderByDescending(p => p.Price).ToList().ForEach( p => Console.WriteLine(p));
                
                // Reserve
                
                numbers.Reverse().ToList().ForEach( n=> Console.WriteLine(n));

                // GroupBy
                var result_3 = products.GroupBy(p => p.Price);
                foreach (var group in result_3)
                {
                    Console.WriteLine(group.Key);
                    foreach (var p in group)
                    {
                        Console.WriteLine(p);
                    }
                }
                // Distinct 
                products.SelectMany(p => p.Colors).ToList().ForEach(mau=>Console.WriteLine(mau)); //in ra tat ca cac mau 
                products.SelectMany(p => p.Colors).Distinct().ToList().ForEach(mau=>Console.WriteLine(mau)); //in ra tat ca cac mau nhung khong trung nhau
                // Single SingleOrDefault
                var product_1 =products.Single(p => p.Price == 600);
                Console.WriteLine(product_1);

                // Any
                var product_2 = products.Any( p=>p.Price == 600); //kiem tra san pham co price =600 neu dung la true...
                Console.WriteLine(product_2);

                // All
                var product_3 = products.All( p=>p.Price > 200); //kiem tra cac san pham san pham co price >600 neu dung la true...
                Console.WriteLine(product_3);

                // Count
                var product_4 = products.Count(p => p.Price >=600); //Dem so phan tu co price >=600
                Console.WriteLine(product_4);

                // In ra ten sam pham, ten thuong hieu, gia (300 ~ 400)
                // gia giam dan

                products.Where( p=> p.Price >=300 && p.Price <=400)
                        .OrderByDescending(p =>p.Price)
                        .Join(brands, p => p.Brand, b=>b.ID, (sp, th) =>
                    {
                        return new 
                        {
                            tenSP =sp.Name,
                            tenTH = th.Name,
                            Gia = sp.Price
                        };
                    }
                )
                .ToList()
                .ForEach(info => Console.WriteLine($"{info.tenSP,15} {info.tenTH,15} {info.Gia,5}"));

                /*
                    1) Xac dinh nguon: from tenphantu in IEnumberables
                    ... join, where, oderby, let tenbien =??
                    2) Lay du lieu: select, group by ...
                */
                

                var result_4 = from p in products  
                                where p.Price == 400
                               select p.Name;
                result_4.ToList().ForEach( name => Console.WriteLine(name));

                // Gia <=500, mau xanh
                var result_5 = from p in products  
                                from color in p.Colors

                                where p.Price <= 500 && color =="Xanh"
                                orderby p.Price descending

                               select new {
                                Ten = p.Name,
                                Gia = p.Price,
                                cacmau = p.Colors
                               };
                result_5.ToList().ForEach( 
                    abc => {
                        Console.WriteLine($"{abc.Ten}-{abc.Gia}-{string.Join(" ",abc.cacmau)}");
                        
                    }
                );

                // Nhom san pham theo gia
                var result_6 = from p in products 
                                group p by p.Price into gr
                                orderby gr.Key
                                select gr
                                ;

                result_6.ToList().ForEach(group=>{
                Console.WriteLine(group.Key);
                group.ToList().ForEach(p=>Console.WriteLine(p));
                }
                );

                //  Doi tuong:
                // Gia
                // Cac san pham
                // So luong
                var result_7 = from p in products 
                                group p by p.Price into gr
                                orderby gr.Key
                                let sl = "So luong la " + gr.Count()
                                select new 
                                {
                                    Gia= gr.Key,
                                    cacsanpham = gr.ToList(),
                                    Soluong = sl
                                }
                                ;

                result_7.ToList().ForEach(i=>{
                Console.WriteLine(i.Gia);
                Console.WriteLine(i.Soluong);
                i.cacsanpham.ForEach(p => Console.WriteLine(p));
                });

                var result_8 = from p in products 
                                join brand in brands on p.Brand equals brand.ID into t
                                from b in t.DefaultIfEmpty()
                                select new 
                                {
                                    Ten = p.Name,
                                    Gia = p.Price,
                                    thuonghieu = (b != null)? b.Name : "Khong co thuong hieu"
                                };
                result_8.ToList().ForEach(p => Console.WriteLine($"{p.Ten,10}-{p.Gia,10}-{p.thuonghieu,10}"));


                
        }   
    }
}
