using System;
using System.Globalization;

namespace ExecProp01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exec 1
            /*Console.Write("N1: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("N2: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;
            Console.WriteLine($"SOMA = {soma}");
            Console.WriteLine();*/

            //Exec 2
            /*double pi = 3.14159;
            Console.Write("Informe o raio: ");
            double raio = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double area = pi * Math.Pow(raio, 2);
            Console.WriteLine($"A = {area.ToString("F4",CultureInfo.InvariantCulture)}");*/

            //Exec 3
            /*int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());

            int diferenca = (a * b) - (c * d);
            Console.WriteLine($"DIFERENÇA = {diferenca}");*/

            //Exec 4 
            /*int codigoFuncionario = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double valorHora = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double salario = (double)horasTrabalhadas * valorHora;
            Console.WriteLine($"NUMBER = {codigoFuncionario}\nSALARY = U${salario.ToString("F2",CultureInfo.InvariantCulture)}");*/

            //Eexc 5
            string[] listaCompra = Console.ReadLine().Split(' ');
            int codPeca = int.Parse(listaCompra[0]);
            int numeroPecas = int.Parse(listaCompra[1]);
            double valorUnitPeca = double.Parse(listaCompra[2],CultureInfo.InvariantCulture);
            string[] listaCompraB = Console.ReadLine().Split(' ');
            int codPecaB = int.Parse(listaCompraB[0]);
            int numeroPecasB = int.Parse(listaCompraB[1]);
            double valorUnitPecaB = double.Parse(listaCompraB[2], CultureInfo.InvariantCulture);
            double valorASerPago = ((double)numeroPecas * valorUnitPeca)+((double)numeroPecasB*valorUnitPecaB);
            Console.WriteLine($"VALOR A PAGAR: R${valorASerPago.ToString("F2",CultureInfo.InvariantCulture)}");
        }
    }
}
