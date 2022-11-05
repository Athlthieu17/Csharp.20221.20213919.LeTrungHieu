using System;
using System.Reflection;

namespace Type_Attr 
{
    public class Experience 
    {
        public static void _Experience()
        {
            int[] a={1,2,3,4,5};

            Type t1 = typeof(int);
            var t2 = typeof(string);
            var t3 = typeof(Array); 
            var t= a.GetType(); //typeof(Array)
            Console.WriteLine(t.FullName);

            Console.WriteLine("---Cac thuoc tinh---");
            t.GetProperties().ToList().ForEach(
              (PropertyInfo o) => {
                Console.WriteLine(o.Name);
              }  
            );
            Console.WriteLine("---Cac truong du lieu---");
            t.GetFields().ToList().ForEach(
              (FieldInfo o) => {
                Console.WriteLine(o.Name);
              }  
            );

            Console.WriteLine("---Cac phuong thuc---");
            t.GetMethods().ToList().ForEach(
              (MethodInfo o) => {
                Console.WriteLine(o.Name);
              }  
            );
        }
    }
}