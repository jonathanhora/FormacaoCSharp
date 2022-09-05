using System;
using System.Collections.Generic;
using System.Text;
using ByteBank.bytebank.Modelos.ADM.Funcionarios;

namespace ByteBank.bytebank.Modelos.ADM.Utilitario
{
    class GerenciadorDeBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.getBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
