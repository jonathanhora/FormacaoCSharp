using System;
using System.Collections.Generic;
using System.Text;
using ByteBanck_ADM.SisemaInterno;

namespace ByteBanck_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }
        public string Login { get; set; }
        public bool Autenticar(string senha, string login)
        {
            return (Senha == senha && Login == login);
        }
    }
}
