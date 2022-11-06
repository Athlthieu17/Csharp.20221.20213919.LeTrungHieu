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
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Uri,DNS,Ping
            // UriTest.Test();
            // TestPing._ping();

            // Http Request - HttpClient (GET/POST)
            // HttpRe._get();
            
            var url = "https://postman-echo.com/post";

            var coockies = new CookieContainer();

            using var handle = new SocketsHttpHandler();
            handle.AllowAutoRedirect = true;
            handle.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip; // ho tro giai nen html
            handle.UseCookies = true; // luu coockie
            handle.CookieContainer = coockies;
            


            using var httpClient = new HttpClient(handle);

            using var httpRequestMessage = new HttpRequestMessage();

            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri(url);
            httpRequestMessage.Headers.Add("User-Agent","Mozilla/5.0");

            var parameters=new List<KeyValuePair<string,string>>(); 
            parameters.Add(new KeyValuePair<string,string>("key1","value1"));
            parameters.Add(new KeyValuePair<string,string>("key2","value2"));

            httpRequestMessage.Content = new FormUrlEncodedContent(parameters);

            var response = await httpClient.SendAsync(httpRequestMessage);

            coockies.GetCookies(new Uri(url)).ToList().ForEach(
                c => {
                    Console.WriteLine($"{c.Name} :{c.Value}");
                }
            );

            var html = await response.Content.ReadAsStringAsync();

            Console.WriteLine(html);

            
        } 
    }
}