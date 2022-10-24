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
        //SortedList 
        //Queue -- vao truoc ra truoc
        //Stack -- vao sau ra truoc
        //LinkedList - dang danh sach lien ket
        // Dictionary
        // HashSet

        static void Main(string[] args)
        {
        //     Queue<string> cachoso = new Queue<string>();

        //     cachoso.Enqueue("ho so 1");
        //     cachoso.Enqueue("ho so 2");
        //     cachoso.Enqueue("ho so 3");

        //     //
        //     var hoso = cachoso.Dequeue(); //loai bo  phan tu dau tien cua danh sach -> tra ve gia tri do
        //     Console.WriteLine($"Xu ly {hoso} - {cachoso.Count}");
            
            // Stack<string> hanghoa = new Stack<string>();
            // hanghoa.Push("mat hang 1");
            // hanghoa.Push("mat hang 2");
            // hanghoa.Push("mat hang 3");

            // var mathang= hanghoa.Pop();
            // Console.WriteLine($"Boc do {mathang}"); 

            // LinkedList<string> cacbaihoc = new LinkedList<string>();

            // var bh1 = cacbaihoc.AddFirst("Bai hoc 1");
            // var bh3 = cacbaihoc.AddLast("Bai hoc 3");

            // LinkedListNode<string> bh2 = cacbaihoc.AddAfter(bh1,"Bai hoc 2");

            // cacbaihoc.AddLast("Bai hoc 4");
            // cacbaihoc.AddLast("Bai hoc 5");

            // foreach (var baihoc in cacbaihoc)
            // {
            //     Console.WriteLine(baihoc);
            // }

            // var node = bh2;
            // Console.WriteLine(node.Value);

            // node = node.Next;

            // Console.WriteLine(node.Value);

            Dictionary<string,int> sodem = new Dictionary<string, int>()
            {
                ["one"] = 1,
                ["two"] = 2
            };
            // thêm hoặc cập nhật
            sodem["three"] = 3;
            sodem.Add("four",4);
            
            // var keys = sodem.Keys;
            // foreach (var k in keys)
            // {
            //     var value = sodem[k];
            //     Console.WriteLine($"{k} = {value}");
            // }

            // foreach (KeyValuePair<string,int> item in sodem)
            // {
            //     Console.WriteLine($"{item.Key} -> {item.Value}");
            // }

            HashSet<int> set1= new HashSet<int>() 
            {
                1,2,3,5,6,7
            };
            HashSet<int> set2= new HashSet<int>() 
            {
                8,9,1,2,7,6,10
            };

            set1.UnionWith(set2); // gop set 1 va set 2 nhung khong trung nhau ve gia tri
            foreach (int value in set1)
            {
                Console.WriteLine(value);
            }

            set1.IntersectWith(set2); // phep giao set1 va set2

        }
    }
}