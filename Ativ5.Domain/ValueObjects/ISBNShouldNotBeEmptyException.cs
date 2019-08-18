namespace Ativ5.Domain.ValueObjects
{
    public class ISBNShouldNotBeEmptyException : DomainException
    {
        internal ISBNShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
