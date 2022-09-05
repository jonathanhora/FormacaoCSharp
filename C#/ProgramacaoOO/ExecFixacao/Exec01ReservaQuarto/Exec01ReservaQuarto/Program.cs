using System;

namespace Exec01ReservaQuarto
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalQuartos = 10;
            Quartos[] registroQuarto = new Quartos[totalQuartos];

            Console.Write("Quantidade de quartos alugados: ");
            int quantidadeQuartos = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < quantidadeQuartos; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"#{i+1}:");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int nquarto = int.Parse(Console.ReadLine());

                registroQuarto[nquarto] = new Quartos (nome, email, nquarto);

            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for(int i = 0; i<totalQuartos; i++)
            {
                if (registroQuarto[i] != null)
                {
                    Console.WriteLine(registroQuarto[i]);
                }
            }
        }
    }
}
