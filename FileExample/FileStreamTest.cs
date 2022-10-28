using System;
using System.Text;
namespace FileExample 
{
    class FileStreamTest
    {
        public class Product 
        {
            public int ID {set;get;}
            public double Price {set;get;}

            public string Name {set; get;}

            public void Save (Stream stream)
            {
                // int -> 4 byte
                var byte_id = BitConverter.GetBytes(ID);
                stream.Write(byte_id, 0, 4);
                //double -> 8 byte
                var byte_price = BitConverter.GetBytes(Price);
                stream.Write(byte_price,0,8);
                // chuoi name
                var byte_Name = Encoding.UTF8.GetBytes(Name);
                var byte_leng = BitConverter.GetBytes(byte_Name.Length);
                stream.Write(byte_leng,0,4);
                stream.Write(byte_Name, 0 , byte_Name.Length);
            }

            public void Restore(Stream stream)
            {
                 // int -> 4 byte
                var byte_id = new byte[4];
                stream.Read(byte_id,0,4);

                ID = BitConverter.ToInt32(byte_id,0);

                //double -> 8 byte
                var byte_price = new byte[8];
                stream.Read(byte_price,0,8);
                Price = BitConverter.ToDouble(byte_price,0);
                // chuoi name
                var byte_leng = new byte[4];
                stream.Read(byte_leng,0,4);
                int leng = BitConverter.ToInt32(byte_leng,0);


                var byte_Name = new byte[leng];
                stream.Read(byte_Name,0,leng);
                Name = Encoding.UTF8.GetString(byte_Name,0,leng);
            }
        }
        public static void Product_TestNew() {
            Product product = new Product()
            {
                ID = 10,
                Price = 10,
                Name = "San pham abc"
            };
            string path = "data.dat";
            using var stream = new FileStream(path: path, FileMode.OpenOrCreate); 
            product.Save(stream);
            

        }

        public static void Product_TestRestore() 
        {
            Product product = new Product();
            string path = "data.dat";
            using var stream = new FileStream(path: path, FileMode.OpenOrCreate); 
            product.Restore(stream);
            Console.WriteLine($"{product.Name} - {product.ID} - {product.Price}");
        }
        public static void FileStreamLearn()
        {
            string path = "data.dat";
            using var stream = new FileStream(path: path, FileMode.OpenOrCreate); 
            
            // Luu Du Lieu
            byte[] buffer = {1,2,3,4,5};
            int offset = 0;
            int count = 4;

            stream.Write(buffer,offset,count);

            // Doc du lieu
            int sobytedocduoc = stream.Read(buffer, offset, count);

            // int, double -> bytes

            int abc=1;
            var bytes_abc=BitConverter.GetBytes(abc);
            // bytes --> int, double...
            BitConverter.ToInt32(bytes_abc, 0 );

            string s = "abc";
            var byte_s = Encoding.UTF8.GetBytes(s);

            Encoding.UTF8.GetString(byte_s, 0 , 10);
        }
    }
}