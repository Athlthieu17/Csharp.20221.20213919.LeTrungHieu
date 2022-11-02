using System;

namespace ASYNC_AWAIT 
{
    class Program
    {
        static void doSomeThing(int seconds,string mgs,ConsoleColor color)
        {
            string a = "abc";

            lock(Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{mgs, 10}..Start");
                Console.ResetColor();
            }
            for (int i = 1; i <= seconds;i++)
            {
                lock(Console.Out)
                {
                Console.ForegroundColor = color;
                Console.WriteLine($"{mgs, 10}{i,2}");
                Console.ResetColor();

                }
                Thread.Sleep(1000);
            }
            lock(Console.Out)
            {
                Console.ForegroundColor = color;
                Console.WriteLine($"{mgs, 10}..End");
                Console.ResetColor();
            }
        }
        
        // asynchronous  (multi thread)
        static Task Task2()
        {
             Task t2 = new Task(
                () => {
                    doSomeThing(10,"T2", ConsoleColor.DarkGreen);
                }
            ) ;// () => {}
            t2.Start();
            return t2;

        }
        static Task Task3()
        {
            Task t3 = new Task(
                (object ob) => {
                    string tentacvu = (string)ob;
                    doSomeThing(7,tentacvu , ConsoleColor.Cyan);
                }
                , "T3"); 
                t3.Start();
                return t3;
        }
        static void Main(string[] args)
        {
            // asynchronous
            // Task , Task<T>
            Task t2 = new Task(
                () => {
                    doSomeThing(10,"T2", ConsoleColor.DarkGreen);
                }
            ) ;// () => {}
            Task t3 = new Task(
                (object ob) => {
                    string tentacvu = (string)ob;
                    doSomeThing(7,tentacvu , ConsoleColor.Cyan);
                }
                , "T3"); 
            t2.Start(); // Thread
            t3.Start(); // Thread
            doSomeThing(5, "T1",ConsoleColor.DarkBlue);
            // t2.Wait();
            // t3.Wait();
            Task.WaitAll(t2,t3);
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}