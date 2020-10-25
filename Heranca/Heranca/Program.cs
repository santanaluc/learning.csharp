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

            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING
            Account acc1 = bacc;
            //A variavel Account recebe qualquer um que seja derivado de uma subclasse dela
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0);
            Account acc3 = new SavingsAccount(1004, "Ana", 0.0, 0.01);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
            //acc2.Loan(100.0);
            //Só pode fazer o loan se fizer primeiro o downcasting 

            //BusinessAccount acc5 = (BusinessAccount)acc3;
            //Da erro pois o acc3 é instanciado como SavingsAccount e SavingsAccount não tem nada a ver com BusinessAccount
            //teste acima sendo feito
            if (acc3 is BusinessAccount)
            {
                //BusinessAccount acc5 = (BusinessAccount)acc3;
                BusinessAccount acc5 = acc3 as BusinessAccount;
                //acima, outra forma de fazer o casting
                acc5.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            //if acima falhou pous acc3 não é uma businessAccount
            //if abaixo não falhou pois acc3 é um SavingsAccount
            if (acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                // SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("UPDATE!");
            }

            //Downcast deve ser usado somente quando necessário pois é inseguro


            //Aula: "Sobreposicao, palavras virtual, override e base"
            Account acc6 = new Account(1005, "Alex", 500.0);
            Account acc7 = new SavingsAccount(1006, "Anna", 500.0, 0.01);
            acc6.Withdraw(10.0);
            acc7.Withdraw(10.0);
            Console.WriteLine(acc6.Balance);
            Console.WriteLine(acc7.Balance);
        }
    }
}
