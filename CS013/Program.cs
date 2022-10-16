using System;

namespace CS013
{
    class Program
    {
        /* 
            Tính kế thừa
            A, B
            B kế thừa A
            A - cơ sở, cha
            B - kế thừa, con

            class B:A
            {

            }

            Animal
            - Legs
            - Weight
            - ShowLegs()

            Cat : Animal
            {

            }

        */
        class Animal
        {
            public Animal() 
            {
                Console.WriteLine("Khoi tao Animal");
            }

            public Animal(string abc)
            {
                Console.WriteLine("Khoi tao Animal 2");

            }
            public int Legs {set;get;}

            public float Weight {set;get;}

            public void ShowLegs() {
                Console.WriteLine($"Legs:{Legs}"); 
            }
        }
        class Cat : Animal 
        {
            public string Food;

            public Cat() :base("abc")
            {
                this.Legs = 4;
                this.Food = "Mouse";
                Console.Write("khoi tao Cat");
            }

            public void Eat()
            {
                Console.WriteLine(Food);
            }
            public new void ShowLegs() {
                Console.WriteLine($"Loai meo co:{Legs} chan");
            }

            public void Showinfo()
            {
                base.ShowLegs(); //lớp cơ sở
                ShowLegs(); // lớp kế thừa
            }
        }    
    

        static void Main(String[] args)
        {
            Cat c = new Cat();
            c.Showinfo(); 
            
        }
    }
}