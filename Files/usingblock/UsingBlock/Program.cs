using System;
using System.IO;

namespace UsingBlock
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\csharp\nivelamento\ws-2\File1.txt";

            //Tratando erro
            try
            {
                //executado e fechado
                using (StreamReader sr = File.OpenText(path))
                {
                    //será executado e fechado
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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
