namespace Ativ5.Domain.Baskets
{
    public class AuthorShouldNotBeEmptyException : DomainException
    {
        internal AuthorShouldNotBeEmptyException(string message)
            : base(message)
        { }
    }
}
