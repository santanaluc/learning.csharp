using System;
using Exercicio05.Entities;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("10/22/2020 00:59:59"), 
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!", 
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good Night");
            Comment c4 = new Comment("May the Force be with you");
            Post p2 = new Post(
                DateTime.Parse("10/22/2020 01:12:00"),
                "Good night guys",
                "See you tomorrow",
                2);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
