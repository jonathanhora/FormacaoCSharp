using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.bytebank.Modelos.ADM.Funcionarios
{
    class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public override double getBonificacao()
        {
            return this.Salario * 0.25;
        }
    }
}
