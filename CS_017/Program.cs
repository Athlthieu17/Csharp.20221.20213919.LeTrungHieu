using System;

namespace CS_017
{
    class CountNumber
    {
        public static int Number = 0; 
        public static void Info()
        {
            Console.WriteLine("So lan truy cap:" + Number);

        }
        public void Count()
        {
            Number++;
        }
    }
    class Student
    {
        public readonly string name ; //chi doc
        public Student(string _name)
        {
            this.name = _name;
        }
    }
    
    class Vector 
    {
        double x;
        double y;

        public Vector(double _x,double _y)
        {
            x= _x;
            y= _y;
        }
        public void Info()
        {
            Console.WriteLine($"x={x}, y={y}");
        }

        // vector <- vector + vector
        public static Vector operator+(Vector v1, Vector v2)
        {
            return new Vector(v1.x+v2.x, v1.y+v2.y);
        }
        public static Vector operator+(Vector v1, double value)
        {
            return new Vector(v1.x+value, v1.y+value);
        }

        // Indexer [chiso]
        public double this[int i]
        {
            set{
                switch (i)
                {
                    case 0: //x
                        x = value;
                    break;
                    case 1: //y
                        y = value;
                    break;
                    default:    
                        throw new Exception("Chi so sai");
                    
                }
            }
            get {

                switch (i)
                {
                case 0: //x
                    return x;
                
                case 1: //y
                    return y;
                
                default:    
                    throw new Exception("Chi so sai");
                
                }
            }
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            // CountNumber.Info();
            // Console.WriteLine(CountNumber.Number);
            // CountNumber c1 = new CountNumber();
            // CountNumber c2 = new CountNumber();

            // c1.Count();
            // c1.Count();

            // CountNumber.Info();
            // Student s = new Student("hieuLt");

            // Console.WriteLine(s.name);

            // Vector v1= new Vector(2,3);
            // Vector v2= new Vector(1,3);
            
            
            // var v3 = v1+v2;

            // var v4 = v3+10;

            // v3.Info();
            // v4.Info();

            Vector v = new Vector(2,3);
            // v[0] ~ x
            // v[1] ~ y

            // v["toa do x"] ~ x
            // v["toa do y"] ~ y

            v[0] = 5;
            v[1] = 6;

            v.Info();

            Console.WriteLine(v[3]);


        }
    }
}