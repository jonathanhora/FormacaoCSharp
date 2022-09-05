using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec04ConversorDeMoedas
{
    class ConversorDeMoeda
    {
        public static double ValorAPagar(double cotacao, double quantidade)
        {
            return cotacao * quantidade * 1.06;
        }
    }
}
