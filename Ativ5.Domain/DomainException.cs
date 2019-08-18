namespace Ativ5.Domain
{
    public class DomainException : Ativ5Exception
    {
        public string BusinessMessage { get; private set; }

        public DomainException(string businessMessage)
        {
            BusinessMessage = businessMessage;
        }
    }
}
