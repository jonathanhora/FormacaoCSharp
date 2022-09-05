// using _05_ByteBank;

using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }

        public static int TotalDeContasCriadas { get; private set; }
        public static double TaxaOperacao { get; private set; }
        public int ContadorSaquesNaoPermiidos { get; private set; }
        public static int ContadorTranferenciasNaoPermitidas { get; private set; }


        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            private set
            {
                if (value <= 0)
                {
                    return;
                }

                _agencia = value;
            }
        }
        public int Numero { get; }

        private double _saldo = 100;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;

            if(agencia <= 0)
            {
                throw new ArgumentException("Agência deve ser maior que ZERO", nameof(agencia));
            }
            if(numero <= 0)
            {
                throw new ArgumentException("valores devem ser maior que zero");
            }
            TaxaOperacao = 30 / TotalDeContasCriadas;
            TotalDeContasCriadas++;
        }


        public void Sacar(double valor)
        {
 
            if (valor <= 0 && _saldo < valor)
            {
                ContadorSaquesNaoPermiidos++;
                throw new SaldoInsuficienteException(_saldo, valor);
            }

            _saldo -= valor;

        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }


        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException)
            {
                ContadorTranferenciasNaoPermitidas++;
                throw new ArgumentException("Valor inválido", nameof(valor));
            }
            contaDestino.Depositar(valor);
        }
    
    }
}
