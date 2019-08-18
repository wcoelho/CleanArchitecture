namespace Ativ5.WebApi.UseCases.RemoveBook
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.RemoveBook;
    using Microsoft.AspNetCore.Mvc;

    public class Presenter : IOutputBoundary<RemoveBookOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public RemoveBookOutput Output { get; private set; }

        public void Populate(RemoveBookOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new ObjectResult(new Model(
                response.Order.OrderDate,
                response.UpdatedTotalPrice
            ));
        }
    }
}
