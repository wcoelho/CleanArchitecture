namespace Ativ5.WebApi.UseCases.RemoveBook
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.RemoveBook;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class BasketsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<RemoveBookInput> removeBookInput;
        private readonly Presenter removeBookPresenter;
        
        public BasketsController(
            IInputBoundary<RemoveBookInput> removeBookInput,
            Presenter removeBookPresenter)
        {
            this.removeBookInput = removeBookInput;
            this.removeBookPresenter = removeBookPresenter;
        }

        /// <summary>
        /// Remove Book from a basket
        /// </summary>
        [HttpPatch("RemoveBook")]
        public async Task<IActionResult> RemoveBook([FromBody]RemoveBookRequest message)
        {
            var request = new RemoveBookInput(message.BookId, message.BasketId);

            await removeBookInput.Process(request);
            return removeBookPresenter.ViewModel;
        }
    }
}
