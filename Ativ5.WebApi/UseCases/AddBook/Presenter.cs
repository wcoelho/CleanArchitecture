namespace Ativ5.WebApi.UseCases.AddBook
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.AddBook;
    using Microsoft.AspNetCore.Mvc;

    public class Presenter : IOutputBoundary<AddBookOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public AddBookOutput Output { get; private set; }

        public void Populate(AddBookOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new ObjectResult(new Model(
                response.Order.CustomerId,
                response.Order.OrderDate,
                response.UpdatedTotalPrice
            ));
        }
    }
}
