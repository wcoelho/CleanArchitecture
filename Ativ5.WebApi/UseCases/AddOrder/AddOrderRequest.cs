namespace Ativ5.WebApi.UseCases.AddOrder
{
    using System;
    public class AddOrderRequest
    {
        public Guid OrderId { get; set; }

        public Guid BasketId { get; set; }

        public Guid CustomerId { get; set; }

        public double Amount { get; set; }
    }
}
