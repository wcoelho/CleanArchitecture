namespace Ativ5.Domain.Baskets
{
    public class BookNotFoundException : DomainException
    {
        public BookNotFoundException(string message)
            : base(message)
        { }
    }
}
