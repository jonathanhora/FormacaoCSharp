using ByteBanck_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBanck_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.GetBonificacao();
        }
        //public void Registrar(Diretor funcionario)
        //{
        //    this.totalBonificacao += funcionario.GetBonificacao();
        //}

        public double GetBonificacao
        {
            get
            {
                return totalBonificacao; 
            }
        }
    }
}
