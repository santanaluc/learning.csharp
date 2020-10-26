using System;
using System.IO;

namespace PathX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Path realiza operacoes com strings que contém informações de arquivos ou pastas");
            Console.WriteLine();

            string path = @"D:\csharp\nivelamento\ws-2\myfolder\File1.txt";
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path)); // pega somente as pastas
            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar); // somente a barra invertida
            Console.WriteLine("PathSeparator: " + Path.PathSeparator); // ; é utilizado para separar a pasta
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}
