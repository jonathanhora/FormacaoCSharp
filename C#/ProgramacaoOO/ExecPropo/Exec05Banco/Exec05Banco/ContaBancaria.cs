using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exec05Banco
{
    class ContaBancaria
    {
        public int NumeroConta { get; private set; }
        private double Taxa = 5.00;
        public string Nome { get; set; }
        public double ValorConta { get; private set; }

        public ContaBancaria(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }

        public ContaBancaria(int numeroConta, string nome, double valorConta) : this(numeroConta, nome)
        {
            Depositar(valorConta);
        }

        public void Depositar(double deposito)
        {
            ValorConta += deposito;
        }

        public void Saque(double valorSaque)
        {
             ValorConta -= Taxa + valorSaque;
        }

        public override string ToString()
        {
            return $"Conta {NumeroConta}, Titular: {Nome}, Saldo: $ {ValorConta.ToString("F2", CultureInfo.InvariantCulture)}";
        }



    }
}
