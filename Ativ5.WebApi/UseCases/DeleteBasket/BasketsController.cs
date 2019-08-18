namespace Ativ5.WebApi.UseCases.DeleteBasket
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.DeleteBasket;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class BasketsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<DeleteInput> deleteBasketInput;
        private readonly Presenter deletePresenter;
        public BasketsController(
            IInputBoundary<DeleteInput> deleteBasketnput,
            Presenter deletePresenter)
        {
            this.deleteBasketInput = deleteBasketnput;
            this.deletePresenter = deletePresenter;
        }

        /// <summary>
        /// Delete the basket
        /// </summary>
        [HttpDelete("{basketId}")]
        public async Task<IActionResult> Delete(Guid basketId)
        {
            var request = new DeleteInput(basketId);

            await deleteBasketInput.Process(request);
            return deletePresenter.ViewModel;
        }
    }
}
