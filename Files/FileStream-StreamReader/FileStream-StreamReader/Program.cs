using System;
using System.IO;

namespace FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\csharp\nivelamento\ws-2\File1.txt";
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error acurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //Fechar as strings
                if (sr != null) sr.Close();
            }
        }
    }
}
