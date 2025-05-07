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
            Console.WriteLine("Digite o valor em USD para conversão:");
            double valor = double.Parse(Console.ReadLine());
            double valorConvertido = Rates.ConvertCurrency(valor, "USD", "BRL");
            Console.WriteLine( valor + "USD = R$" + valorConvertido + "BRL" );
        }
    }
}

