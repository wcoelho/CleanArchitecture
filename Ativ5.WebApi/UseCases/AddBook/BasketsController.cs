namespace Ativ5.WebApi.UseCases.AddBook
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.AddBook;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class BasketsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<AddBookInput> addBookInput;
        private readonly Presenter addBookPresenter;

        public BasketsController(
            IInputBoundary<AddBookInput> addBookInput,
            Presenter addBookPresenter)
        {
            this.addBookInput = addBookInput;
            this.addBookPresenter = addBookPresenter;
        }

        /// <summary>
        /// Add Book to a basket
        /// </summary>
        [HttpPatch("AddBook")]
        public async Task<IActionResult> AddBook([FromBody]AddBookRequest message)
        {
            var request = new AddBookInput(message.BookId, message.BasketId);

            await addBookInput.Process(request);
            return addBookPresenter.ViewModel;
        }
    }
}
