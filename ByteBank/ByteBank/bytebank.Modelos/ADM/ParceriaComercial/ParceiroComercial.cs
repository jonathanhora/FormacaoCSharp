using System;
using System.Collections.Generic;
using System.Text;
using bytebank.Modelos.ADM.SistemaInterno;

namespace ByteBank.bytebank.Modelos.ADM.ParceriaComercial
{
    class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
