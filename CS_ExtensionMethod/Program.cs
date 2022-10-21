using System;
using System.Linq;
using MyLib;
namespace CS_ExtensionMethod
{
        // extension method
        // lop tinh static ~
    static class Abc 
    {
        public static void Print(this string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ResetColor();
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            // string s = "hi";
            // s.Print(ConsoleColor.DarkBlue);
            double a= 2.5;
            Console.WriteLine(a.BinhPhuong());
            
        }
    }
}