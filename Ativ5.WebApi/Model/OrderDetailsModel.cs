namespace Ativ5.WebApi.Model
{
    using System;

    public class OrderDetailsModel
    {
        public Guid BasketId { get; }
        public double Amount { get; }
        public DateTime OrderDate { get; }
        public OrderDetailsModel(Guid basketId, double amount, DateTime orderDate)
        {
            BasketId = basketId;
            Amount = amount;
            OrderDate = orderDate;
        }
    }
}
