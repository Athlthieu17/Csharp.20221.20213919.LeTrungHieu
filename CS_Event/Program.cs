using System;

namespace CS_Event 
{
    class Program
    {
        public delegate void EventInput(int x);
        /* 
            publisher => class - phat su kien
            subsriber => class - nhan su kien

        */
        // publisher 
        class UserInput 
        {
            public event EventInput _EventInput; 

            public void Input() 
            {
                do
                {
                string s = Console.ReadLine();
                int i = Int32.Parse(s);
                // phat su kien
                _EventInput?.Invoke(i);
                    
                } while (true);

            }
        }
        class SolveSQRT 
        {
            public void Sub(UserInput input) {
                input._EventInput += SQRT; 
            }
            public void SQRT(int i) 
            {
                Console.WriteLine($"Sqrt({i}) is {Math.Sqrt(i)}");
            }
        }

        class TinhBinhPhuong 
        {
            public void Sub(UserInput input) {
                input._EventInput += BinhPhuong; 
            }
            public void BinhPhuong(int i) 
            {
                Console.WriteLine($"BinhPhuong({i}) is {i * i}");
            }
        }
        static void Main(string[] args)
        {
            //publisher
            UserInput userInput = new UserInput();

            // subcriber
            // SolveSQRT solvesqrt = new SolveSQRT();
            // solvesqrt.Sub(userInput);

            TinhBinhPhuong solveSQR = new TinhBinhPhuong();
            solveSQR.Sub(userInput);
            userInput.Input();
        }
    }
}