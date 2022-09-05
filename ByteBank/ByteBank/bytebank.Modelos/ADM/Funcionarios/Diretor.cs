using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.bytebank.Modelos.ADM.Funcionarios
{
    class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(5000, cpf)
        {
            Console.WriteLine("Criando DIRETOR");
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.5;
        }
    }
}
