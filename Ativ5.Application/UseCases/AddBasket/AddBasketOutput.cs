namespace Ativ5.Application.UseCases.AddBasket
{
    using Ativ5.Application.Outputs;
    using Ativ5.Domain.Customers;
    public class AddBasketOutput
    {
        public CustomerOutput Customer { get; private set; }
        public BasketOutput Basket { get; private set; }

        public AddBasketOutput()
        {

        }

        public AddBasketOutput(CustomerOutput customer, BasketOutput basket)
        {
            Customer = customer;
            Basket = basket;
        }
    }
}
