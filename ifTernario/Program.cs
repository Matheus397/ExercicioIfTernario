using System;
using System.Globalization;

namespace ifTernario
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Cadastre o preco de um produto qualquer");

            double preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            //como seria com uma estrutura convencional de IF
            //if (preco < 20.0)
            //    desconto = preco * 0.1;

            //else
            //    desconto = preco * 0.05;

            Console.WriteLine(desconto);

        }
    }
}
