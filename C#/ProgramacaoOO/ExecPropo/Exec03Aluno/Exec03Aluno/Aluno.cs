using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exec03Aluno
{
    class Aluno
    {
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string Status()
        {
            if (NotaFinal() >= 60.00)
            {
                return $"NOTA FINAL = {NotaFinal().ToString("F2",CultureInfo.InvariantCulture)}\nAPROVADO";
            }
            else
            {
                double faltou = 60.00 - NotaFinal();
                return $"NOTA FINAL = {NotaFinal().ToString("F2",CultureInfo.InvariantCulture)}\nREPROVADO\nFALTARAM  {faltou.ToString("F2",CultureInfo.InvariantCulture)} PONTOS";
            }
        }
    }
}
