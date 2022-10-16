using System;

namespace CS007_Class {
    class Student {
        public string name;
        
        public Student(string name) {
            this.name = name;
            Console.WriteLine("khoi tao" + name);

        }
        ~Student() 
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("huy" + name);
            Console.ResetColor();

        }
    }
    class Program {
        static void Main(string[] args)
        {
            // Vukhi sungluc; //null
            // sungluc = new Vukhi();
            
            // sungluc.name = "Sung luc";
            // sungluc.Thietlapsatthuong(5);

            // Console.WriteLine(sungluc.Satthuong);
            // sungluc.Noisanxuat = "My";
            // Console.WriteLine(sungluc.Noisanxuat);

            // Vukhi sungmay = new Vukhi("Concu", 10);
            // sungluc.Tancong();
            // sungmay.Tancong();
            Student student;

            for (int i = 0; i < 1000000; i++)
            {
                student = new Student("Sinh vien "+i);
                student = null;
            }

            
             
            

            GC.Collect();
        }
    }
}