using System;

namespace CS10
{
    class Program 
    {
        class Abc 
        {
            public void XinChao() => Console.WriteLine("Hello CSharp");
        }
        static void Main(string[] args) 
        {   
            // null, nullable
            // null
            Abc a = new Abc();

            // if (a != null) 
            //     a.XinChao();

            // a?.XinChao();

            int? age;
            age = null;
            age= 10;
            if(age.HasValue)
            {
                int _age = age.Value;
                Console.WriteLine(_age);
            }
        }
    }
}