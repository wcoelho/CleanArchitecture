namespace Ativ5.Application.UseCases.DeleteBasket
{
    using System;
    public class DeleteInput
    {
        public Guid BasketId { get; private set; }
        public DeleteInput(Guid guid)
        {
            this.BasketId = guid;
        }
    }
}
