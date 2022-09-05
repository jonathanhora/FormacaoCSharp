using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBanck_ADM.Basicas
{
    public class Divisao
    {
        public double Calcular(double numeroA, double numeroB)
        {
            if(numeroB == 0)
            {
                return 0;
            }
            else
            {
                return numeroA / numeroB;
            }
        }
    }
}
