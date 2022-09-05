using ByteBanck_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBanck_ADM.SisemaInterno
{
    public interface IAutenticavel
    {
        public bool Autenticar(string senha, string login);
    }
}
