namespace Ativ5.Application.UseCases.DeleteBasket
{
    using System;
    public class DeleteOutput
    {
        public Guid BasketId { get; private set; }
        public DeleteOutput()
        {

        }

        public DeleteOutput(Guid basketId)
        {
            BasketId = basketId;
        }
    }
}
