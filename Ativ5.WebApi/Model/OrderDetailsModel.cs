namespace Ativ5.WebApi.Model
{
    using System;

    public class OrderDetailsModel
    {
        public Guid BasketId { get; }
        public double FinalPrice { get; }
        public DateTime OrderDate { get; }
        public OrderDetailsModel(Guid basketId, double finalPrice, DateTime orderDate)
        {
            BasketId = basketId;
            FinalPrice = finalPrice;
            OrderDate = orderDate;
        }
    }
}
