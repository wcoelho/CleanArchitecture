namespace Ativ5.WebApi.UseCases.RemoveBook
{
    using System;

    public class Model
    {        
        public DateTime OrderDate { get; }
        public double UpdatedTotalPrice { get; }

        public Model(DateTime orderDate,
            double updatedTotalPrice)
        {
            OrderDate = orderDate;
            UpdatedTotalPrice = updatedTotalPrice;
        }
    }
}
