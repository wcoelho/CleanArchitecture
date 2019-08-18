namespace Ativ5.WebApi.UseCases.GetBasketDetails
{
    using Ativ5.Application;
    using Ativ5.Application.Outputs;
    using Ativ5.WebApi.Model;
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using Utils;

    public class Presenter : IOutputBoundary<BasketOutput>
    {
        public IActionResult ViewModel { get; private set; }
        public BasketOutput Output { get; private set; }

        public void Populate(BasketOutput output)
        {
            Output = output;

            if (output == null)
            {
                ViewModel = new NoContentResult();
                return;
            }

            DateTime orderDateTime = DateTime.Now;

            OrderDetailsModel order = new OrderDetailsModel(output.BasketId, output.TotalPrice, orderDateTime);

            List<BookDetailsModel> books = Utils.GetBookDetailsModel(output.Books);
            
            ViewModel = new ObjectResult(new BasketDetailsModel(
                output.BasketId,
                output.TotalPrice,
                books));
        }
    }
}
