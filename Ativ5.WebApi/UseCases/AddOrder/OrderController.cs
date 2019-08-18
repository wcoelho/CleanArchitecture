namespace Ativ5.WebApi.UseCases.AddOrder
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.AddOrder;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class OrdersController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<AddOrderInput> addOrderInput;
        private readonly Presenter addOrderPresenter;

        public OrdersController(
            IInputBoundary<AddOrderInput> addOrderInput,
            Presenter addOrderPresenter)
        {
            this.addOrderInput = addOrderInput;
            this.addOrderPresenter = addOrderPresenter;
        }

        /// <summary>
        /// Add Order
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> AddOrder([FromBody]AddOrderRequest message)
        {
            var request = new AddOrderInput(message.CustomerId, message.BasketId, message.Amount);
            await addOrderInput.Process(request);
            return addOrderPresenter.ViewModel;
        }
    }
}
