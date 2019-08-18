namespace Ativ5.WebApi.UseCases.Checkout
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.Checkout;
    using Microsoft.AspNetCore.Mvc;

    public class Presenter : IOutputBoundary<CheckoutOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public CheckoutOutput Output { get; private set; }

        public void Populate(CheckoutOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new ObjectResult(new Model(
                response.Basket.BasketId,
                response.Customer.CustomerId,
                response.OrderDate,
                response.TotalPrice
            ));
        }
    }
}
