namespace Ativ5.WebApi.UseCases.Register
{
    using Ativ5.Application;
    using Ativ5.Application.UseCases.Register;
    using Ativ5.WebApi.Model;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using Utils;

    public class Presenter : IOutputBoundary<RegisterOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public RegisterOutput Output { get; private set; }

        public void Populate(RegisterOutput response)
        {
            Output = response;

            if (response == null)
            {
                ViewModel = new NoContentResult();
                return;
            }
  
            Model model = new Model(
                response.Customer.CustomerId,
                response.Customer.Personnummer,
                response.Customer.Name
            );

            ViewModel = new CreatedAtRouteResult("GetCustomer", new { customerId = model.CustomerId }, model);
        }
    }
}
