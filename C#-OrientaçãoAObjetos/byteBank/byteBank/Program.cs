using System;
using byteBank;

namespace byteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente conta1 = new ContaCorrente();
            //conta1.titular = "Jonathan";
            //conta1.conta = "123-J";
            //conta1.numero_agencia = 07;
            //conta1.nome_agencia = "Agencia Central";
            //conta1.saldo = 100;

            //ContaCorrente conta2 = new ContaCorrente();
            //conta2.titular = "Vanessa";
            //conta2.conta = "124-V";
            //conta2.numero_agencia = 09;
            //conta2.nome_agencia = "Agencia Central";
            //conta2.saldo = 500;

            //Console.WriteLine($"Saldo da {conta2.titular} é {conta2.saldo}");
            //bool saque = conta2.Sacar(250);
            //Console.WriteLine($"Saque realizado? {saque}");
            //Console.WriteLine($"Saldo da {conta2.titular} após o saque é  {conta2.saldo}");


            //Console.WriteLine($"Saldo da {conta1.titular} é {conta1.saldo}");
            //bool deposito = conta1.Depositar(1000);
            //Console.WriteLine($"Deposito realizado? {deposito}");
            //Console.WriteLine($"Saldo da {conta1.titular} após o deposito é  {conta1.saldo}");


            //Console.WriteLine($"Saldo da {conta1.titular} é {conta1.saldo}");
            //bool transferencia = conta1.Transferir(500, conta2);
            //Console.WriteLine($"Transferencia realizada? {transferencia}");
            //Console.WriteLine($"Saldo da {conta1.titular} após o transferir para {conta2.titular} é  {conta1.saldo}");
            //Console.WriteLine($"Saldo da {conta2.titular} após o receber a transferencia  {conta2.saldo}");

            //Console.WriteLine();
            //Console.WriteLine("----------");
            //conta1.ExibirDadosDaConta();
            //Console.WriteLine();
            //Console.WriteLine("----------");
            //conta2.ExibirDadosDaConta();

            ContaCorrente conta1 = new ContaCorrente("123-J", 07);
            conta1.Titular.Nome = "Jonathan";
            conta1.Titular.Cpf = "42157965214";
            conta1.Titular.Profissao = "Desenvolvedor Júnior";
            conta1.Nome_agencia = "Agencia Central";
            conta1.Saldo = 15000;
            conta1.ExibirDadosDaConta();

            Console.WriteLine();
            ContaCorrente conta2 = new ContaCorrente("123-J", 07);
            conta2.Titular.Nome = "Jorge";
            conta2.Titular.Cpf = "45712568241";
            conta2.Titular.Profissao = "Desenvolvedor Pleno";
            conta2.Nome_agencia = "Agencia Central";
            conta2.Saldo = 150000;
            conta2.ExibirDadosDaConta();

            Console.WriteLine();
            Console.WriteLine("Contas criadas: "+ContaCorrente.TotalDeContasCriadas);

            Console.ReadKey();
        }
    }
}
