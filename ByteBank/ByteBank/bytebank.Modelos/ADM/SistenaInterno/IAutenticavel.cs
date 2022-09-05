using System;
using System.Collections.Generic;
using System.Text;

namespace ByteBank.bytebank.Modelos.ADM.SistenaInterno
{
    public interface IAutenticavel
    {
        bool Autenticar(string senha);
    }
}
