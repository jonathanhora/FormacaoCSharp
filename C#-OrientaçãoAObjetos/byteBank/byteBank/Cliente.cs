using System;
namespace byteBank.Titular
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }

        public void ExibirDadosConta()
        {
            Console.WriteLine($"Nome: {Nome}.\nCPF: {Cpf}.\nProfissão: {Profissao}.");
        }

        public Cliente()
        {
            QuantidadeCliente++;
        }

        public static int QuantidadeCliente { get; set; }
    }
}
