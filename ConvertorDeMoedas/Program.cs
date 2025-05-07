using System;
using ConvertorDeMoedas;
using Newtonsoft.Json;

namespace ExchangeRate_API
{
    class Program
    {
        static void Main(string[] args)
        {
            Rates.Import();
            Console.WriteLine("Você quer converter qual moeda");
            Console.WriteLine("Ex: USD -- BRL / EUR -- BRL");
            string NomeMoeda = Console.ReadLine();
            Console.WriteLine("Para qual ?");
            string NomeMoeda1 = Console.ReadLine();
            Console.WriteLine("E a quantidade ?");
            double valor = double.Parse(Console.ReadLine());
            double valorConvertido = Rates.ConvertCurrency(valor,NomeMoeda , NomeMoeda1);
            Console.WriteLine("$" + valor + " " + NomeMoeda + "=" +  "" + valorConvertido + NomeMoeda1 );
        }
    }
}

