using System;
using System.Globalization;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:f1} reais", nome, idade, saldo);

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:f1} reais ");

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("f1",CultureInfo.InvariantCulture ) + " reais ");
        }
    }
}
