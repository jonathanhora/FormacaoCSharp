using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.bytebank.Modelos.ADM.Funcionarios
{
    class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string cpf) : base(3000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.1;
        }
    }
}
