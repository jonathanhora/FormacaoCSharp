using System;
using System.Globalization;

namespace ExecProp02
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec01
            /*Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor < 0)
            {
                Console.WriteLine("NEGATIVO!");
            }
            else if (valor>0)
            {
                Console.WriteLine("POSITIVO!");
            }
            else
            {
                Console.WriteLine("NULO!");
            }*/

            //exec02
            /*Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }*/

            //exec03
            /*Console.Write("Digite dois valores: ");
            string [] valores = Console.ReadLine().Split(' ');
            int valorA = int.Parse(valores[0]);
            int valorB = int.Parse(valores[1]);

            if (valorA%valorB==0 || valorB % valorA == 0)
            {
                Console.WriteLine("SÃO MÚLTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÃO MÚLTIPLOS");
            }*/

            //exec 04
            /*Console.Write("Informe o horário inicial e final: ");
            string[] horario = Console.ReadLine().Split(' ');
            int horaA = int.Parse(horario[0]);
            int horaB = int.Parse(horario[1]);
            int tempo = 0;

            if (horaA > horaB)
            {
                tempo = (24 - horaA) + horaB;
            }
            else if (horaB > horaA)
            {
                tempo = horaB - horaA;
            }
            else
            {
                tempo = 24;
            }

            Console.WriteLine($"O jogo durou {tempo} hora(s)");*/

            //exerc05

            /*Console.WriteLine($"Codigo   Especificacao    Preço\n" +
                              $" 1      Cachorro quente   R$4.00\n" +
                              $" 2         X-salada       R$4.50\n" +
                              $" 3         X-bacon        R$5.00\n" +
                              $" 4      Torrada simples   R$2.00\n" +
                              $" 5        Refrigerante    R$1.50");
            Console.WriteLine("---------------------------------\n");
            double[] produdos =new double[] { 4.00, 4.50, 5.00, 2.00, 1.50 };
            Console.Write("Selecione o código e a quantidade: ");
            string[] opcao = Console.ReadLine().Split(' ');
            int codigo = int.Parse(opcao[0]);
            double quantidade = int.Parse(opcao[1]);
            double total = quantidade * produdos[codigo - 1];
            Console.WriteLine($"Total: R$ {total.ToString("F2",CultureInfo.InvariantCulture)}");*/

            //exerc06
            /*Console.Write("Digite uma valor qualquer: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            string intervalo;

            if(valor >=0 && valor <= 25)
            {
                intervalo = "Intervalo (0,25)";
            }
            else if (valor > 25 && valor <= 50)
            {
                intervalo = "Intervalo (25,50)";
            }
            else if(valor>50 && valor <= 75)
            {
                intervalo = "Intervalo (50,75)";
            }
            else if(valor>75 && valor <= 100)
            {
                intervalo = "Intervalo (75,100)";
            }
            else
            {
                intervalo = "Fora do Intervalo";
            }

            Console.WriteLine(intervalo);*/

            //exec07

        }
    }
}
