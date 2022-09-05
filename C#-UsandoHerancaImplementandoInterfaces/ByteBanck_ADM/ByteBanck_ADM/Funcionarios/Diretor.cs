using ByteBanck_ADM.SisemaInterno;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBanck_ADM.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {

        }

        //override -> para reescrever o método herdado da classe mãe/pai
        public override double GetBonificacao()
        {
            //base -> pegar o método do pai/mãe
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}
