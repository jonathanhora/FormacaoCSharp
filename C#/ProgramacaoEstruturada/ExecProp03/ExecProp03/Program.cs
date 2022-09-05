using System;

namespace ExecProp03
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec01
            /*Console.Write("Senha: ");
            string tentativa = Console.ReadLine();
            string senha = "2002";
            
            while (tentativa != senha)
            {
                Console.WriteLine("Senha inválida\nTente novamente!\n");
                Console.Write("Senha: ");
                tentativa = Console.ReadLine();
            }
            Console.WriteLine("Acesso Permitido");*/

            //exec02
            /*Console.Write("Coordenadas: ");
            string[] coordenadas = Console.ReadLine().Split(' ');
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                string quadrante = Quadrante(x, y);
                Console.WriteLine("Quadrante: " + quadrante);
                Console.Write("Coordenadas: ");
                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }*/

            //exec 03

            Console.Write("Informe um tipo: ");
            int opcao = int.Parse(Console.ReadLine());
            int conta1 = 0;
            int conta2 = 0;
            int conta3 = 0;

            while (opcao != 4)
            {
                if (opcao >= 1 && opcao < 4)
                {
                    if (opcao == 1)
                    {
                        conta1 += 1;
                    }
                    else if (opcao == 2)
                    {
                        conta2 += 1;
                    }
                    else
                    {
                        conta3 += 1;
                    }

                }
                else
                {
                    Console.WriteLine("Opção inválida\n");
                }

                Console.Write("Informe um tipo: ");
                opcao = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"\n\nMuito Obrigado\nAlcool: {conta1}\nGasolina: {conta2}\nDiesel: {conta3}");

        }

        /*static string Quadrante(int a, int b)
        {
            string quadrante = "";

            if (a > 0 && b > 0)
            {
                quadrante = "Primeiro";
            }
            if (a < 0 && b > 0)
            {
                quadrante = "Segundo";
            }
            if (a < 0 && b < 0)
            {
                quadrante = "Terceiro";
            }
            if (a > 0 && b < 0)
            {
                quadrante = "Quarto";
            }

            return quadrante;
        }*/

    }
}
