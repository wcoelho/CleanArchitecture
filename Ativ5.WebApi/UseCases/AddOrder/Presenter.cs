namespace Ativ5.WebApi.UseCases.AddOrder
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.AddOrder;
    using Microsoft.AspNetCore.Mvc;

    public class Presenter : IOutputBoundary<AddOrderOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public AddOrderOutput Output { get; private set; }

        public void Populate(AddOrderOutput response)
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
