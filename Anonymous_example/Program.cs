using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymous_example
{
    class Program 
    {
            // Anonymous - kieu du lieu vo danh
            // Object - thuoc tinh - chi doc
            // new {thuoctinh = gia tri, thuoctinh2 = giatri2}

            // Dynamic - kieu du lieu dong
        class Studen 
        {
            public string Name {set; get;}

            public int DateOfBirth {set; get;}

            public string PlaceOfBirth {set;get;}
        }

        static void PrintInfo(dynamic obj) 
        {
            obj.Name = "Justin";
            obj.Hello();
        }

        class _Studen {
            public string Name {set;get;}

            public void Hello() => Console.WriteLine(Name);

        }
        static void Main(string[] args)
        {
            var _Product = new {
                Ten = "Iphone 8",
                Price = 1000, 
                DateOnly = 2018
            }; 


        List<Studen> _Students = new List<Studen>()
        {
            new Studen() {Name = "Nam", DateOfBirth = 2000 , PlaceOfBirth = "Binh Duong"},
            new Studen() {Name = "Dan", DateOfBirth = 2002 , PlaceOfBirth = "Nam Dinh"},
            new Studen() {Name = "Long", DateOfBirth = 2001 , PlaceOfBirth = "Vinh Phuc"},
            new Studen() {Name = "Hieu", DateOfBirth = 2000 , PlaceOfBirth = "Nam Dinh"}
        };

        var Result = from SV in _Students
                     where SV.DateOfBirth <=2001
                     select new {
                        Name = SV.Name,
                        Place = SV.PlaceOfBirth
                    };

        _Studen abc=new _Studen();
        PrintInfo(abc);
        // foreach (var studen in Result)
        // {
        //     Console.WriteLine(studen.Name + ' ' + studen.Place);
        // }
            
        
        // Console.WriteLine(_Product.Ten);
        // Console.WriteLine(_Product.Price);
        }
    }
}