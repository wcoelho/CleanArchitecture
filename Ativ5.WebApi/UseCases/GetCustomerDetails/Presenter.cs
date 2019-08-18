namespace Ativ5.WebApi.UseCases.GetCustomerDetails
{
    using Ativ5.Application;
    using Ativ5.Application.Outputs;
    using Ativ5.WebApi.Model;
    using Utils;    
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    public class Presenter : IOutputBoundary<CustomerOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public CustomerOutput Output { get; private set; }

        public void Populate(CustomerOutput output)
        {
            Output = output;

            if (output == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            List<OrderDetailsModel> orders = Utils.GetOrderDetailsModel(output.Orders);
           
            CustomerDetailsModel model = new CustomerDetailsModel(
                output.CustomerId,
                output.Personnummer,
                output.Name,
                orders
            );

            ViewModel = new ObjectResult(model);
        }
    }
}
