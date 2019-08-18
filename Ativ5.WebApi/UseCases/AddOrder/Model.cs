namespace Ativ5.WebApi.UseCases.Checkout
{
    using System;

    public class Model
    {                
        public Guid CustomerId { get; }
        public Guid BasketId { get; }
        public DateTime OrderDate { get; }
        public double UpdatedTotalPrice { get; }

        public Model(Guid basketId, Guid customerId, DateTime orderDate,
            double updatedTotalPrice)
        {
            BasketId = basketId;
            CustomerId = customerId;
            OrderDate = orderDate;
            UpdatedTotalPrice = updatedTotalPrice;
        }
    }
}
