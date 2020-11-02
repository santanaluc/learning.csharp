using System;
using System.IO;
using Exercicio1.Entities;
using System.Collections.Generic;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            Console.WriteLine("Enter file full path: ");
            //string path = Console.ReadLine();
            var path = @"D:\csharp\Temp\in2.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');
                        string name = line[0];
                        string votes = line[1];

                        dict["name"] = name;
                        dict["votes"] = votes;

                        foreach (var value in dict)
                        {
                            Console.WriteLine(value.Key + ": " + value.Value);
                        }
                    }

                    
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}