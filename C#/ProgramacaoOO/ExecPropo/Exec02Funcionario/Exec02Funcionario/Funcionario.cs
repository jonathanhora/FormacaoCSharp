using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exec02Funcionario
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double aumento)
        {
            SalarioBruto = ((SalarioBruto * aumento) / 100) + SalarioBruto;
        }
        public override string ToString()
        {
            return "Funcionario: "
                + Nome
                + ", $ "
                + SalarioLiquido().ToString("F2",CultureInfo.InvariantCulture );
        }

    }
}
