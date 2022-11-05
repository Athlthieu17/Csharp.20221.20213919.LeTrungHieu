using System;
using System.Net;

namespace NET1 
{
    class UriTest 
    {
        public static void Test() 
        {
            string url = "https://xuanthulab.net/lap-trinh/csharp/?page=3#acff";
            var uri = new Uri(url);
            var uritype = typeof(Uri);
            uritype.GetProperties().ToList().ForEach(property => {
                Console.WriteLine($"{property.Name, 15} {property.GetValue(uri)}");
            });
            Console.WriteLine($"Segments: {string.Join(",", uri.Segments)}");

            var hostname = Dns.GetHostName();
            Console.WriteLine(hostname);

            var url_1 = "Https://xuanthulab.net";
            var uri_1 = new Uri(url_1);
            Console.WriteLine(uri_1.Host);

            var iphostentry = Dns.GetHostEntry(uri_1.Host);
            Console.WriteLine(iphostentry.HostName);
            iphostentry.AddressList.ToList().ForEach(ip => {
                Console.WriteLine(ip);
            });
        }
    }
}