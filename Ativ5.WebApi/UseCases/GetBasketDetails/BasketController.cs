namespace Ativ5.WebApi.UseCases.GetBasketDetails
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.GetBasketDetails;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class BasketsController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<GetBasketDetailsInput> getBasketDetailsInput;
        private readonly Presenter getBasketDetailsPresenter;

        public BasketsController(
            IInputBoundary<GetBasketDetailsInput> getBasketDetailsInput,
            Presenter getBasketDetailsPresenter)
        {
            this.getBasketDetailsInput = getBasketDetailsInput;
            this.getBasketDetailsPresenter = getBasketDetailsPresenter;
        }

        /// <summary>
        /// Get an basket details
        /// </summary>
        [HttpGet("{basketId}", Name = "GetBasket")]
        public async Task<IActionResult> Get(Guid basketId)
        {
            var request = new GetBasketDetailsInput(basketId);

            await getBasketDetailsInput.Process(request);
            return getBasketDetailsPresenter.ViewModel;
        }
    }
}
