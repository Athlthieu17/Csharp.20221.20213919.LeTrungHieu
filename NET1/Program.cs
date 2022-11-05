using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace NET1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Uri,DNS,Ping
            // UriTest.Test();
            // TestPing._ping();

            // Http Request - HttpClient (GET/POST)
            HttpRe._get();

        } 
    }
}