using System;
using System.Collections.Generic;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "79186387"; // vai sobrescrever pois nao aceita repetições

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");
            //Console.WriteLine(cookies["email"]);

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            } else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: " + cookies.Count);
            Console.WriteLine("All cookies:");
            //pode colocar var no lugar "KeyValuePair<string, string>"
            foreach (KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
