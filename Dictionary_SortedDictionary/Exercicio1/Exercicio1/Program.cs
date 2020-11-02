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
            Dictionary<string, int> dict = new Dictionary<string, int>();

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
                        int numberVotes = int.Parse(line[1]);
                        if (!dict.ContainsKey(name))
                        {
                            dict.Add(name, numberVotes);
                        }
                        else
                        {
                            dict[name] += numberVotes;
                        }
                    }

                    foreach (var item in dict)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
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