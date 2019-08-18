namespace Ativ5.WebApi.UseCases.Checkout
{
    using System;
    public class CheckoutRequest
    {
        public Guid OrderId { get; set; }

        public Guid BasketId { get; set; }

        public Guid CustomerId { get; set; }

        public double FinalPrice { get; set; }
    }
}
