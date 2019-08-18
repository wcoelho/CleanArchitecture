namespace Ativ5.Domain.Orders
{
    public class OrderNotFoundException : DomainException
    {
        public OrderNotFoundException(string message)
            : base(message)
        { }
    }
}
