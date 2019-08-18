namespace Ativ5.Domain.Baskets
{
    public class BasketNotFoundException : DomainException
    {
        public BasketNotFoundException(string message)
            : base(message)
        { }
    }
}
