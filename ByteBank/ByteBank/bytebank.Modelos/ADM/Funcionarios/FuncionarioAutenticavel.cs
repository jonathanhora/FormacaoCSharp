using System;
using System.Collections.Generic;
using System.Text;
using bytebank.Modelos.ADM.SistemaInterno;

namespace ByteBank.bytebank.Modelos.ADM.Funcionarios
{
    class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
