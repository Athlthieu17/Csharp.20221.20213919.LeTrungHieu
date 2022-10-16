using System;

// delegate (Type) bien = method
namespace CS_Delegate 
{
    public delegate void ShowLog(string message);
    class Program 
    {
        static void Info(string s) 
        {
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Warning(string s)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine(s);
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            // ShowLog log = null;

            // log = Info; 
            // if (log != null)
            // {
            // log("Hello"); 
            // log.Invoke("Hello abc");

            // }
            // log?.Invoke("Hello");

            // log = Warning;
            // log("Learning delegate");

            // log += Info;  
            // log += Info;  
            // log += Info;  

            // log += Warning;
            // log += Warning;
            // log?.Invoke("Hello everyone");

            //Action, Func : delegate - gereric

            // Action action; // ~ delegate void KIEU();

            // Action<string, int> action1; // ~ delegate void KIEU(string s, int i);
            // Action<string> action2; // ~delegate void KIEU(string s);

            // action2 =Warning;

            // action2 += Info;

            // action2?.Invoke("Notifycation by Action"); 
            
        }
    }
}