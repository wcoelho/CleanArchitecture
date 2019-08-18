namespace Ativ5.Application.UseCases.AddOrder
{
    using Ativ5.Application.Outputs;
    using System;

    public class AddOrderOutput
    {
        public CustomerOutput Customer { get; private set; }
        public BasketOutput Basket { get; private set; }
        public DateTime OrderDate { get; private set; }
        public double TotalPrice { get; private set; }

        public AddOrderOutput()
        {

        }

        public AddOrderOutput(CustomerOutput customer, BasketOutput basket, DateTime orderDate, double totalPrice)
        {
            Customer = customer;
            Basket = basket;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }
    }
}
