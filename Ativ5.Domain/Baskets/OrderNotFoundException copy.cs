namespace Ativ5.Domain.Baskets
{
    public class OrderNotFoundException : DomainException
    {
        public OrderNotFoundException(string message)
            : base(message)
        { }
    }
}
