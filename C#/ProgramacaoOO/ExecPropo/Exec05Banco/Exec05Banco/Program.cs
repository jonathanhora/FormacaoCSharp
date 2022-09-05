using System;
using System.Globalization;

namespace Exec05Banco
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria conta;
            Console.Write("Entre com o número da Conta: ");
            int codigo =int.Parse( Console.ReadLine());
            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char statusDeposito = char.Parse(Console.ReadLine().ToLower());

            double quantia;

            if (statusDeposito == 's')
            {
                Console.Write("Entre com o valor de Depósito inicial: ");
                quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(codigo, nome, quantia);
            }
            else
            {
                conta = new ContaBancaria(codigo, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o Depósito: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(quantia);
            Console.WriteLine("Dados Atualizados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre com o valor para saque: ");
            quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(quantia);
            Console.WriteLine("Dados Atualizados da Conta:");
            Console.WriteLine(conta);

        }
    }
}
