using System;
namespace CouseAula152ExcecoesPersonalizadas.Entities.Exceptions
{
    public class DomainException : ApplicationException
    {
        public DomainException( string message) : base(message)
        {
        }
    }
}
