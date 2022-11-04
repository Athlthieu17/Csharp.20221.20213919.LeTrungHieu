using System;
using Newtonsoft.Json;
using Adath.Utils;
namespace Usepackage
{
    class Product
    {
        public string Name {set;get;}
        public DateTime Expiry {set;get;}

        public string[] Sizes {set;get;}

    }
    class Program
    {
        // dotnet add package packageName --version xxx
        // dotnet remove package packageName --version xxx
        // dotnet restore
        // dotnet add tenduan.csproj reference thuvien.csproj
        // dotnet add C:\Users\W10.TQ\LearningCS\Usepackage\Usepackage.csproj reference C:\Users\W10.TQ\LearningCS\Utils\Utils.csproj
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Product product = new Product();

            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };


            string json = JsonConvert.SerializeObject(product);
            Console.WriteLine(json);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }

            string json_1 = @"{
            ""Name"": ""Dien thoai Iphone"",
            ""Expiry"": ""2021-1-30T00:00:00"",
            ""Size"": [
                ""Large"",
                ""Small""
            ]
            }";

            var product_1 = JsonConvert.DeserializeObject<Product>(json_1);

            Console.WriteLine(product_1.Name);
            Console.WriteLine(product_1.Expiry.ToLongDateString());
            
            double a = 421421321356;

            var kq = CovertMoneyToText.NumberToText(a);
            Console.WriteLine(kq);
            CovertMoneyToText.Hello();
            
        }
    }
}