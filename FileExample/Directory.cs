using System;

namespace FileExample 
{
    
    class Directory 
    {
        public static void ListFileDirectory(string name_file)  //duyet het file va thu muc co chua trong thu muc
        {
            string[] directories = System.IO.Directory.GetDirectories(name_file);
            string[] files = System.IO.Directory.GetFiles(name_file);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            foreach (var directory in directories)
            {
                Console.WriteLine(directory);
            }
        }
        public static void DirectoryTest(string name_file) 
        {
            Directory.Delete(name_file);
            if (Directory.Exists(name_file))
            {
                Console.WriteLine($"{name_file} - ton tai");
            }
            else Console.WriteLine($"{name_file} - khong ton tai");

            ListFileDirectory(name_file);
        }

        private static bool Exists(string name_file)
        {
            throw new NotImplementedException();
        }

        private static void Delete(string name_file)
        {
            throw new NotImplementedException();
        }
    }
}