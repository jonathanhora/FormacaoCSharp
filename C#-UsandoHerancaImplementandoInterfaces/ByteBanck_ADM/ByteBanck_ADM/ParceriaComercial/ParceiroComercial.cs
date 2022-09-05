using ByteBanck_ADM.SisemaInterno;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBanck_ADM.ParceriaComercial
{
    public class ParceiroComercial : IAutenticavel
    {

        public string Senha { get; set; }
        public string Login { get; set; }

        public bool Autenticar(string senha, string login)
        {
            return (Senha == senha && Login == login);
        }
    }
}
