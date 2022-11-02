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
        static async Task Task2()
        {
             Task t2 = new Task(
                () => {
                    doSomeThing(10,"T2", ConsoleColor.DarkGreen);
                }
            ) ;// () => {}
            t2.Start();
            await t2;
            Console.WriteLine("T2 da hoan thanh");

        }
        
        static async Task Task3()
        {
            Task t3 = new Task(
                (object ob) => {
                    string tentacvu = (string)ob;
                    doSomeThing(7,tentacvu , ConsoleColor.Cyan);
                }
                , "T3"); 
                t3.Start();
                await t3;
                Console.WriteLine("T3 da hoan thanh");

        }
        static async Task<string> Task4() 
        {
            Task<string> t4 = new Task<string>(
                () => {
                    doSomeThing(10,"T4",ConsoleColor.DarkYellow);
                    return "Return from T4";
                }
            ); // () => { return string;}
            t4.Start();
            var kq4 = await t4;
            Console.WriteLine("T4 hoan thanh");
            return kq4;
        }
        static async Task<string> Task5()
        {
            Task<string> t5 = new Task<string>(
                (object ob) => {
                    string t = (string)ob;
                    doSomeThing(4,t,ConsoleColor.Yellow);
                    return $"return from {t}";
                }
                , "T5" 
            ); // (object ob) => { return string;}
            t5.Start();
            string kq5 = await t5;
            return kq5;
        } 

        static async Task Abc()
        {
            // Task task = new Task(() => {
            //     // ... cac chi thi  
            // });
            // task.Start();
            // await task;
            // // ...
            await File.WriteAllTextAsync("1.txt","dsadas");
            // ...
        }
        static async Task<string> GetWeb(string url) 
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage result= await httpClient.GetAsync(url);
            string content = await result.Content.ReadAsStringAsync();
            return content;
        }
        static async Task<Object> abc()
        {
            Task<Object> task = new Task<object>(
                () => {
                    // .. cac tac vu
                    return new object();
                }
            );
            task.Start();
            var kq =await task;
            return kq;
        }
        static async Task Main(string[] args)
        {
            // asynchronous
            // Task , Task<T>
            // Task t2 = Task2();
            // Task t3 = Task3();
            
            // t2.Wait();
            // t3.Wait();
            // Task.WaitAll(t2,t3);
            // await t2;
            // await t3;

            // Task<T>
            // Task<string> t4 = Task4();
            // Task<string> t5 = Task5();
            var task = GetWeb("https://www.24h.com.vn/");
            
            
            doSomeThing(5, "T1",ConsoleColor.DarkBlue);
            // var kq4 = await t4;
            // var kq5 = await t5;
            var content = await task;


            // Console.WriteLine(kq4);
            // Console.WriteLine(kq5);
            Console.WriteLine(content);
            Console.ReadKey();
        }
    }
}