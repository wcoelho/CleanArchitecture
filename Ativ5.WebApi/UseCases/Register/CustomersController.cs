namespace Ativ5.WebApi.UseCases.Register
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.Register;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;

    [Route("api/[controller]")]
    public class CustomersController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly IInputBoundary<RegisterInput> registerInput;
        private readonly Presenter registerPresenter;

        public CustomersController(
            IInputBoundary<RegisterInput> registerInput,
            Presenter registerPresenter)
        {
            this.registerInput = registerInput;
            this.registerPresenter = registerPresenter;
        }

        /// <summary>
        /// Register a new Customer
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]RegisterRequest message)
        {
            var request = new RegisterInput(message.PIN, message.Name);
            await registerInput.Process(request);
            return registerPresenter.ViewModel;
        }
        
    }
}
