using System;
using System.IO;

namespace FileStream_StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\csharp\nivelamento\ws-2\File1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            //Parte nao resumida
            try
            {
                fs = new FileStream(path, FileMode.Open);
                sr = new StreamReader(fs);
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
                if (fs != null) sr.Close();
            }
        }
    }
}
