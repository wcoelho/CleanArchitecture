namespace Ativ5.WebApi.UseCases.Checkout
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.Checkout;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class OrdersController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<CheckoutInput> checkoutInput;
        private readonly Presenter checkoutPresenter;

        public OrdersController(
            IInputBoundary<CheckoutInput> checkoutInput,
            Presenter checkoutPresenter)
        {
            this.checkoutInput = checkoutInput;
            this.checkoutPresenter = checkoutPresenter;
        }

        /// <summary>
        /// Add Order - Checkout operation
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Checkout([FromBody]CheckoutRequest message)
        {
            var request = new CheckoutInput(message.CustomerId, message.BasketId, message.FinalPrice);
            await checkoutInput.Process(request);
            return checkoutPresenter.ViewModel;
        }
    }
}
