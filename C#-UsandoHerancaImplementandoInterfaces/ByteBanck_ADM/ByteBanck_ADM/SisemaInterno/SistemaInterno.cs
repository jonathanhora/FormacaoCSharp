using System;
using System.Collections.Generic;
using System.Text;
using ByteBanck_ADM.Funcionarios;
using ByteBanck_ADM.ParceriaComercial;

namespace ByteBanck_ADM.SisemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha, string login)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha, login);
            if(usuarioAutenticado == true)
            {
                Console.WriteLine("Bem vindo ao sistema");
                return true;
            }
            else
            {
                Console.WriteLine("Login ou senha Incorreta");
                return false;
            }
        }
    }
}
