using System;
using System.Globalization;

namespace execAula23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("último nome, idade e altura (mesma linha)");
            string[] dados = Console.ReadLine().Split(' ');
            string ultimoNome = dados[0];
            int idade =int.Parse( dados[1]);
            double altura = double.Parse(dados[2],CultureInfo.InvariantCulture);

            Console.WriteLine($"Dados digitados:\n{nome}\n{quartos}\n{preco.ToString("F2",CultureInfo.InvariantCulture)}\n{ultimoNome}\n{idade}\n{altura.ToString(CultureInfo.InvariantCulture)}");
        }
    }
}
