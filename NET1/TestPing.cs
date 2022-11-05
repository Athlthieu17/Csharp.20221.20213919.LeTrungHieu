using System;
using System.Net.NetworkInformation;

namespace NET1 
{
    class TestPing 
    {
        public static void _ping()
        {
            var ping = new Ping();
            var pingReply = ping.Send("google.com.vn");
            Console.WriteLine(pingReply.Status);
            if (pingReply.Status == IPStatus.Success)
            {
                Console.WriteLine(pingReply.RoundtripTime);
                Console.WriteLine(pingReply.Address);
            }
        }
    }
}