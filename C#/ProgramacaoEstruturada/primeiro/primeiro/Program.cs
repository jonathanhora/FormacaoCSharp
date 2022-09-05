using System;
using System.Globalization;

namespace primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 6580.50;
            double medida = 53.234567;

            Console.WriteLine($"Produtos:\n{produto1}, cujo preço é ${preco1.ToString("F2")}.\n{produto2}, cujo preço é ${preco2.ToString("F2")}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}");
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: "+ medida.ToString("F8"));
            Console.WriteLine("Arredondando (três casas decimais: "+ medida.ToString("F3"));
            Console.WriteLine("Separador decima invariant culture: "+ medida.ToString("F3",CultureInfo.InvariantCulture));''*/

            double n = 10.00 / 8.00;
            Console.WriteLine(n);

            string frase = Console.ReadLine();
            Console.WriteLine(frase);
        }
    }
}
