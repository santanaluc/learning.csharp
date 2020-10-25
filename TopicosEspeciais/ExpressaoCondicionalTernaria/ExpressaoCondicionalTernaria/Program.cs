namespace ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //(condicao) ? valor_se_verdadeiro : valor_se_falso

            double preco = double.Parse(Console.ReadLine());
            double desconto;
            //if normal
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            } else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine(desconto);

            //ternario
            double descontoTernario = (preco < 20.0) ? preco * 0.1 : preco * 0.05;
            Console.WriteLine(descontoTernario);
        }
    }
}
