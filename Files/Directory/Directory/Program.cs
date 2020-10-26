using System;
using System.IO;
using System.Collections.Generic;

namespace DirectoryX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Directory == Static Members \nDirectoryInfo == Instance Members");

            Console.WriteLine("==========================================================");

            string path = @"D:\csharp\nivelamento\ws-2\myfolder";

            try
            {
                //Listar diretórios(pastas)
                //Pode declarar com var também
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                //resultado será uma coleção contendo os strings correspondentes as pastas
                Console.WriteLine("Folders:");
                foreach(string s in folders)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("==========================================================");

                //Listar arquivos
                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                //resultado será uma coleção contendo os strings correspondentes as pastas
                Console.WriteLine("Files:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }

                Console.WriteLine("==========================================================");

                Directory.CreateDirectory(path + "\\newFolder");

                Console.WriteLine("==========================================================");
                //DirectoryInfo
                DirectoryInfo foldersTest = new DirectoryInfo(path); //verificar depois
                Console.WriteLine(foldersTest);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
