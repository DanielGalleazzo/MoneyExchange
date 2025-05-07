using System;
using ConvertorDeMoedas;
using Newtonsoft.Json; // Necessário baixar essa biblioteca!

namespace ExchangeRate_API
{
    class Program
    {
        static void Main(string[] args)
        {
            Rates.Import();
            Console.WriteLine("Você quer converter qual moeda");
            Console.WriteLine("Ex: USD -- BRL / EUR -- BRL");
            string NomeMoeda = Console.ReadLine().ToUpper();
            Console.WriteLine("Para qual ?");
            string NomeMoeda1 = Console.ReadLine().ToUpper();
            Console.WriteLine("E a quantidade ?");
            double valor = double.Parse(Console.ReadLine());
            double valorConvertido = Rates.ConvertCurrency(valor,NomeMoeda , NomeMoeda1);
            Console.WriteLine(valor + " " + NomeMoeda + " = " +  "" + valorConvertido + " "+ NomeMoeda1 );
        }
    }
}

