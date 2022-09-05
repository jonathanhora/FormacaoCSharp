using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBanck_ADM.Funcionarios
{
    class Auxiliar : Funcionario
    {
        public Auxiliar(string cpf): base(cpf, 2000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.20;
        }
    }
}
