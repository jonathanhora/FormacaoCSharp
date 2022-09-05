using System;
using System.Globalization;

namespace Exec04ConversorDeMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a cotação do dolar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantidade = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago: {ConversorDeMoeda.ValorAPagar(cotacao, quantidade).ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
