using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBanck_ADM.Funcionarios
{
    public class Desenvolvador : Funcionario
    {
        public Desenvolvador(string cpf): base(cpf, 3000)
        {

        }
        public override void AumentarSalario()
        {
            this.Salario *= 0.15;
        }

        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
