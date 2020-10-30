using IComparableX.Entities;
using System;
using System.Collections.Generic;
using System.IO;

namespace IComparableX
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\csharp\nivelamento\ws-2\text.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }

                    list.Sort();//faz o uso da interface comparable
                    
                    foreach(Employee emp in list)
                    {
                        Console.WriteLine(emp);
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
