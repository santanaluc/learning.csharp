using System;
using System.IO;

namespace StreamWriterX
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"D:\csharp\nivelamento\ws-2\File1.txt";
            string targetPath = @"D:\csharp\nivelamento\ws-2\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                } 
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
