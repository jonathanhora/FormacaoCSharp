using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exec02ListaAumentoFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            Console.Write("Quantos funcionários serão registrado? ");
            int quantFunc = int.Parse(Console.ReadLine());

            for (int i = 0; i<quantFunc; i++)
            {
                Console.WriteLine($"Funcionario #{i+1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();

            }

            Console.Write("Entre com o Id do funcionário que vai receber aumento: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario fun = funcionarios.Find(x => x.Id == idAumento);

            if (fun != null)
            {
                Console.Write("Porcentagem de aumento do salario: ");
                double porcentagemaumento = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                fun.AtualizarSalario(porcentagemaumento);
            }
            else
            {
                Console.WriteLine("O Id informado não existe");
            }

            Console.WriteLine();

            foreach( Funcionario obj in funcionarios)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
