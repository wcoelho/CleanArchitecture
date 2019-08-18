namespace Ativ5.Domain.ValueObjects
{
    public class TitleShouldNotBeEmptyException : DomainException
    {
        internal TitleShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
