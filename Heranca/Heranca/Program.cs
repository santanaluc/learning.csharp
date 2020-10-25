using System;
using Heranca.Entities;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //Permite o reuso de atributos e métodos 
            //Relacao "é-um"
            // Heranca é uma associação entre classes (e nao entre objetos)

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);
            Console.WriteLine(account.Balance);

        }
    }
}
