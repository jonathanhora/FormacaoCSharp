using System;
using System.Globalization;
namespace ExecProp04
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec01
            /*Console.Write("Informe um número: ");
            int entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i<=entrada; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }*/

            //exec02
            /*Console.Write("Números serão digitados: ");
            int quantidade = int.Parse(Console.ReadLine());
            int fora=0,dentro = 0;

            for(int i = 1; i<=quantidade; i++)
            {
                Console.Write($"#{i}: ");
                int entrada = int.Parse(Console.ReadLine());

                if(entrada>9 && entrada < 21)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine($"{dentro} in\n{fora} out");*/

            //exec03
            Console.Write("Número de casos: ");
            double casos = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            double media = 0;

            for (int i =1; i<=casos; i++)
            {
                Console.WriteLine($"Notas #{i}: ");

            }
        }
    }
}
