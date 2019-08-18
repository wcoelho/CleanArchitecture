namespace Ativ5.Application.UseCases.Checkout
{
    using Ativ5.Application.Outputs;
    using System;

    public class CheckoutOutput
    {
        public CustomerOutput Customer { get; private set; }
        public BasketOutput Basket { get; private set; }
        public DateTime OrderDate { get; private set; }
        public double TotalPrice { get; private set; }

        public CheckoutOutput()
        {

        }

        public CheckoutOutput(CustomerOutput customer, BasketOutput basket, DateTime orderDate, double totalPrice)
        {
            Customer = customer;
            Basket = basket;
            OrderDate = orderDate;
            TotalPrice = totalPrice;
        }
    }
}
