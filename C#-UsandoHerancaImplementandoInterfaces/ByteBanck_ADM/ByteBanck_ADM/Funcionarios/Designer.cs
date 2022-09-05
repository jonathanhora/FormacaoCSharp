using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBanck_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf ) : base(cpf, 3000)
        {

        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }
    }
}
