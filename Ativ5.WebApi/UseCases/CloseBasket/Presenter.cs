namespace Ativ5.WebApi.UseCases.DeleteBasket
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.DeleteBasket;
    using Microsoft.AspNetCore.Mvc;

    public class Presenter : IOutputBoundary<DeleteOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public DeleteOutput Output { get; private set; }

        public void Populate(DeleteOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            ViewModel = new OkResult();
        }
    }
}