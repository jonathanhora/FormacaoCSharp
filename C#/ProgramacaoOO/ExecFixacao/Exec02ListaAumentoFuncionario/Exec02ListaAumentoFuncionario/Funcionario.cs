using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exec02ListaAumentoFuncionario
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public Funcionario(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public void AtualizarSalario(double porcentagem)
        {
            Salary = ((porcentagem/100.00)*Salary)+Salary;
        }

        public override string ToString()
        {
            return $"Lista de funcionários atualizada:\n{Id}, {Name}, {Salary.ToString("F2",CultureInfo.InvariantCulture)}";

        }
    }
}
