using System;

namespace NET1
{
    public class clientHttp 
    {
        public static async Task _clientHttp() 
        {
            var url = "https://postman-echo.com/post";

            using var httpClient = new HttpClient();

            using var httpRequestMessage = new HttpRequestMessage();

            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri(url);
            httpRequestMessage.Headers.Add("User-Agent","Mozilla/5.0");

            var parameters=new List<KeyValuePair<string,string>>(); 
            parameters.Add(new KeyValuePair<string,string>("key1","value1"));
            parameters.Add(new KeyValuePair<string,string>("key2","value2"));

            httpRequestMessage.Content = new FormUrlEncodedContent(parameters);

            var response = await httpClient.SendAsync(httpRequestMessage);

            var html = await response.Content.ReadAsStringAsync();

            Console.WriteLine(html);

        }

        public static async Task delegatingHandle() 
        {
            
        }

    }
}