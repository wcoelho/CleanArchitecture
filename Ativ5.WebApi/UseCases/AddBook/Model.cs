namespace Ativ5.WebApi.UseCases.AddBook
{
    using System;

    public class Model
    {                
        public Guid CustomerId { get; }
        public DateTime OrderDate { get; }
        public double UpdatedTotalPrice { get; }

        public Model(Guid customerId, DateTime orderDate,
            double updatedTotalPrice)
        {
            CustomerId = customerId;
            OrderDate = orderDate;
            UpdatedTotalPrice = updatedTotalPrice;
        }
    }
}
