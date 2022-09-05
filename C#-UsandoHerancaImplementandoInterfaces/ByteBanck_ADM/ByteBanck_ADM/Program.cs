using ByteBanck_ADM.Funcionarios;
using System;
using ByteBanck_ADM.Utilitario;
using ByteBanck_ADM.SisemaInterno;
using ByteBanck_ADM.ParceriaComercial;

namespace ByteBanck_ADM
{
    class Program
    {
        static void Main(string[] args)
        {
            //GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
            //Funcionario jonathan = new Funcionario("45124875496", 2500);
            //jonathan.Nome = "Jonathan";

            //Diretor paula = new Diretor("54786582475");
            //paula.Nome = "Paula";

            //Console.WriteLine("Salario Jonathan: "+ jonathan.Salario);
            //Console.WriteLine("Salario Paula: " + paula.Salario);
            //Console.WriteLine( );
            //Console.WriteLine($"Bonificação Jonathan: {jonathan.GetBonificacao()}");
            //Console.WriteLine($"Bonificação Paula : {paula.GetBonificacao()}");

            //Console.WriteLine();
            //gerenciador.Registrar(jonathan);
            //gerenciador.Registrar(paula);
            //Console.WriteLine("Total bonificação: "+gerenciador.GetBonificacao);
            //Console.WriteLine();
            //Console.WriteLine("Totas de funcionários: "+ Funcionario.totalFuncionarios);

            //Console.WriteLine();
            //jonathan.AumentarSalario();
            //Console.WriteLine("Novo salario Jonathan: "+ jonathan.Salario);
            //paula.AumentarSalario();
            //Console.WriteLine("Novo salario Paula: " + paula.Salario);

            //CalcularBonificacao();
            UsarSistema();

            void CalcularBonificacao()
            {
                GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

                Designer miguel = new Designer("21547896547");
                miguel.Nome = "Miguel";

                Desenvolvador jonathan = new Desenvolvador("26584795461");
                jonathan.Nome = "Jonathan";

                Diretor paula = new Diretor("25486935248");
                paula.Nome = "Paula";

                Auxiliar camila = new Auxiliar("25486935248");
                camila.Nome = "Camila";

                GerenteDeContas debora = new GerenteDeContas("32568457961");
                debora.Nome = "Debora";

                gerenciador.Registrar(miguel);
                gerenciador.Registrar(jonathan);
                gerenciador.Registrar(paula);
                gerenciador.Registrar(camila);
                gerenciador.Registrar(debora);

                Console.WriteLine("total de bonificacao: "+ gerenciador.GetBonificacao);

            }

            void UsarSistema()
            {
                SistemaInterno sistemaInterno = new SistemaInterno();

                Diretor jonathan = new Diretor("41259658475");
                jonathan.Nome = "Jonathan";
                jonathan.Login = "jonathan@teste.com";
                jonathan.Senha = "senha1";

                GerenteDeContas vithoria = new GerenteDeContas("41259658475");
                vithoria.Nome = "Vithoria";
                vithoria.Login = "vithoria@teste.com";
                vithoria.Senha = "senha2";

                ParceiroComercial parceiro = new ParceiroComercial();
                parceiro.Senha = "321";
                parceiro.Login = "parceiro@teste";

                sistemaInterno.Logar(jonathan,"senha1", "jonathan@teste.com");
                sistemaInterno.Logar(vithoria, "senha2", "vithoria@teste.com");
                sistemaInterno.Logar(parceiro, "321", "parceiro@teste");
            }
        }
    }
}
