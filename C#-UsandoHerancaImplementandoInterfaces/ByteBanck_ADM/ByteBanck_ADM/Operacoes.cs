using System;
using System.Collections.Generic;
using System.Text;
using ByteBanck_ADM.Basicas;

namespace ByteBanck_ADM
{
    public class Operacoes
    {
        public Adicao Adicao { get; private set; }
        public Subtracao Subtracao { get; private set; }
        public Multiplicacao Multiplicacao { get; private set; }
        public Divisao Divisao { get; private set; }

        public Operacoes()
        {
            this.Adicao = new Adicao();
            this.Subtracao = new Subtracao();
            this.Multiplicacao = new Multiplicacao();
            this.Divisao = new Divisao();
        }
    }
}
