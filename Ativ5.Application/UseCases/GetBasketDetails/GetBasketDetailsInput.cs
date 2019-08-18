namespace Ativ5.Application.UseCases.GetBasketDetails
{
    using System;
    public class GetBasketDetailsInput
    {
        public Guid BasketId { get; private set; }
        public GetBasketDetailsInput(Guid basketId)
        {
            this.BasketId = basketId;
        }
    }
}
