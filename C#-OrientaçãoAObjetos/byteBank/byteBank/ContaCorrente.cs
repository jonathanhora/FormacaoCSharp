using System;
using byteBank;
using byteBank.Titular;

namespace byteBank
{
    public class ContaCorrente
    {
        public ContaCorrente(string conta, int numeroAgencia)
        {
            Conta = conta;
            Numero_agencia = numeroAgencia;
            TotalDeContasCriadas++;
        }

        public ContaCorrente(Cliente cleinte, string conta, int numeroAgencia, string nomeAgencia, double saldo )
        {
            Titular = cleinte;
            Conta = conta;
            Numero_agencia = numeroAgencia;
            Nome_agencia = nomeAgencia;
            Saldo = saldo;
            TotalDeContasCriadas++;
        }


        public Cliente Titular { get; set; } = new Cliente();
        private string _conta { get; set; }

        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if(value == null || value == "" || value.Length < 3)
                {
                   
                }
                else 
                {
                    _conta = value;
                }
                
            }
        }
        private int _numero_agencia;

        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if(value <=0 )
                {
                    
                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string Nome_agencia { get; set; }

        private double _saldo;
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

        public bool Sacar(double valor)
        {
            if(_saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                _saldo = _saldo - valor;
                return true;
            }
        }

        public bool Depositar(double valor)
        {
            if(valor > 0)
            {
                _saldo = _saldo + valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferir(double valor, ContaCorrente contadestino)
        {
            if(_saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                _saldo = _saldo - valor;
                contadestino._saldo = contadestino._saldo + valor;
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Titular.ExibirDadosConta();
            Console.WriteLine($"Conta: {Conta}.\nNúmero Agência: {Numero_agencia}.\nNome da Agência: {Nome_agencia}." +
                $"\nSaldo: {_saldo}");
        }

        public static int TotalDeContasCriadas { get; set; }
  
    }
}