namespace Ativ5.Application.UseCases.AddOrder
{
    using System;

    public class AddOrderInput
    {
        public Guid CustomerId { get; private set; }
        public Guid BasketId { get; private set; }
        public double TotalPrice { get; private set; }

        public DateTime OrderDate { get; private set; }

        public AddOrderInput(Guid customerId, Guid basketId, double totalPrice)
        {
            this.CustomerId = customerId;
            this.BasketId = basketId;
            this.TotalPrice = totalPrice;
            this.OrderDate = DateTime.Now;
        }
    }
}
