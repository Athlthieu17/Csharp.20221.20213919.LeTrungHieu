using System;
using System.Net.Http.Headers;


namespace NET1
{
    class HttpRe 
    {
        
        public static void showHeader(HttpResponseHeaders hearders)
        {
            Console.WriteLine("Cac Headers:");
            foreach (var header in hearders)
            {
                Console.WriteLine($"{header.Key} : {header.Value}");
            }
            
        }
        public static async Task<string> GetWebContent(string url) 
        {
            using var httpClient = new HttpClient();   
            try 
            {
                // Add Header
                httpClient.DefaultRequestHeaders.Add("User-Agent","Mozilla/5.0");
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

                // httpResponseMessage.Headers
                showHeader(httpResponseMessage.Headers);

                string html = await httpResponseMessage.Content.ReadAsStringAsync();
                

                return html;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return "Error";
            }

        }
        public static async Task<byte[]> DownloadDataBytes(string url) 
        {
            using var httpClient = new HttpClient();   
            try 
            {
                // Add Header
                httpClient.DefaultRequestHeaders.Add("User-Agent","Mozilla/5.0");
                HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(url);

                // httpResponseMessage.Headers
                showHeader(httpResponseMessage.Headers);

                var bytes = await httpResponseMessage.Content.ReadAsByteArrayAsync();
                

                return bytes;

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public static async Task downloadStream(string url, string filename)
        {
            HttpClient httpClient = new HttpClient();
            try 
            {
                var httpResponseMessage = await httpClient.GetAsync(url);

                using var stream = await httpResponseMessage.Content.ReadAsStreamAsync();
                
                using var streamWrite = File.OpenWrite(filename);

                int sizeBuffet = 500; 
                
                var buffer = new byte[sizeBuffet];
                
                bool endRead = false;
                do
                {
                    int numbBytes = await stream.ReadAsync(buffer, 0 ,sizeBuffet);
                    if (numbBytes ==0) 
                    {
                        endRead = true;
                    }
                    else 
                    {
                        await streamWrite.WriteAsync(buffer,0,numbBytes);
                    }
                } while (endRead == true);


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static async Task sendAsync() 
        {
            HttpClient httpClient = new HttpClient();

            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri("https://xuanthulab.net");
            var httpResponseMessage = await httpClient.SendAsync(httpRequestMessage);
            
            var html = await httpResponseMessage.Content.ReadAsByteArrayAsync();
            Console.WriteLine(html);
            
        }

        public static async Task formUrlEncodedContent() 
        {
            var httpClient = new HttpClient();

            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri("https://postman-echo.com/post");

            var parameters = new List<KeyValuePair<string,string>>();
            parameters.Add(new KeyValuePair<string,string>("key1","value1"));

            parameters.Add(new KeyValuePair<string,string>("key2","value2-1"));
            parameters.Add(new KeyValuePair<string,string>("key2","value2-2"));

            // Thiết lập Content
            var content =  new FormUrlEncodedContent(parameters);
            httpRequestMessage.Content = content;

            // Thực hiện Post
            var response = await httpClient.SendAsync(httpRequestMessage);

            var responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
            // Khi chạy kết quả trả về cho biết Server đã nhận được dữ liệu Post đến
        }


        public static async Task stringContent() 
        {
            var httpClient = new HttpClient();

            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri("https://postman-echo.com/post");

            // Tạo StringContent
            string jsoncontent = "{\"value1\": \"giatri1\", \"value2\": \"giatri2\"}";
            var httpContent = new StringContent(jsoncontent, Encoding.UTF8, "application/json"); 
            httpRequestMessage.Content = httpContent;

            var response = await httpClient.SendAsync(httpRequestMessage);
            var responseContent = await response.Content.ReadAsStringAsync();

            Console.WriteLine(responseContent);
        }

         public static async Task multipartFormDataContent() 
        {
            var httpClient = new HttpClient();

            var httpRequestMessage = new HttpRequestMessage();
            httpRequestMessage.Method = HttpMethod.Post;
            httpRequestMessage.RequestUri = new Uri("https://postman-echo.com/post");


            // Tạo đối tượng MultipartFormDataContent
            var content = new MultipartFormDataContent();

            // Tạo StreamContent chứa nội dung file upload, sau đó đưa vào content
            Stream fileStream = System.IO.File.OpenRead("Program.cs");
            content.Add(new StreamContent(fileStream), "fileupload", "abc.xyz");

            // Thêm vào MultipartFormDataContent một StringContent
            content.Add(new StringContent("value1"), "key1");
            // Thêm phần tử chứa mạng giá trị (HTML Multi Select)
            content.Add(new StringContent("value2-1"), "key2[]");
            content.Add(new StringContent("value2-2"), "key2[]");


            httpRequestMessage.Content = content;
            var response = await httpClient.SendAsync(httpRequestMessage);
            var responseContent = await response.Content.ReadAsStringAsync();
            Console.WriteLine(responseContent);
        }


        public static async void _get()
        {
            var url = "https://raw.githubusercontent.com/xuanthulabnet/jekyll-example/master/images/jekyll-01.png";

            var task = GetWebContent(url);
            task.Wait();
            var html = task.Result;
            Console.WriteLine(html);

            var bytes  = await DownloadDataBytes(url);

            string filename = "1.png";

            using var stream = new FileStream(filename,FileMode.Create, FileAccess.Write, FileShare.None);
            stream.Write(bytes, 0, bytes.Length);

            await downloadStream(url,"2.png");

            await sendAsync();
            await formUrlEncodedContent();
            await stringContent();
            await multipartFormDataContent();

        }
    }
}