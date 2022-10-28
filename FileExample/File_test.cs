using System;
using System.IO;

namespace FileExample 
{
    class File_test1 
    {
        public static void FileOnTest()
        {
            string filename = "abc.txt"; 
            string content = File.ReadAllText(filename); // gan doc file
            File.WriteAllText(filename,content); // tao file moi
            File.AppendAllText(filename, content); // bo sung vao file 
            
            File.Move("abc.txt","123.txt"); //doi ten file
            File.Copy("123.txt","456.txt"); // copy file
            File.Delete("123.txt"); //Xoa file 
        }
        public static void FileTest2() 
        {
            
        }
    }
}