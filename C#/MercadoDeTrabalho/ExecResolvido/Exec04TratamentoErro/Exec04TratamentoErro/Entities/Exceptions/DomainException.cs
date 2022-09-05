using System;

namespace Exec04TratamentoErro.Entities.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message): base(message)
        {

        }
    }
}
