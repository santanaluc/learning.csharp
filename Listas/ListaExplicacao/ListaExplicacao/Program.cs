using System;
using System.Collections.Generic;

namespace ListaExplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando uma lista vazia
            List<string> list = new List<string>();

            //Instanciando e adicionando na lista
            List<string> list2 = new List<string> { "Marjory", "Geovanna" };

            //Adicionando elementos na lista
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Ana");
            list.Insert(2, "Marco");

            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("List count: " + list.Count);

            Console.WriteLine("--------------------------------------");
            //predicado é uma funcao que pega um valor e retorna verdadeiro ou falso conforme a lógica que está na função
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            Console.WriteLine("--------------------------------------");
            //lê-se: string x tal que x na posição 0 igual a 'A' (lambda)
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("First Position 'A': " + pos2);

            Console.WriteLine("--------------------------------------");
            //Filtrar a lista conforme um predicado
            List<string> list3 = list.FindAll(x => x.Length == 5);
            foreach (string obj in list3)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------");
            list.Remove("Alex");
            Console.WriteLine("Removendo o Alex: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------");
            list.RemoveRange(0, 1);
            Console.WriteLine("Remove Range: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------");
            list.RemoveAt(2);
            Console.WriteLine("Remove At: ");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Remove All 'M': ");
            list.RemoveAll(x => x[0] == 'M');
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }

        //Mesma coisa da expressão lambda na variável s1
        static bool Test(string s)
        {
            return s[0] == 'A';
        }
    }
}
