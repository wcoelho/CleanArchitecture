namespace Ativ5.Application.UseCases.RemoveBook
{
    using System;
    public class RemoveBookInput
    {
        public Guid BookId { get; }
        public Guid BasketId { get; }        

        public RemoveBookInput(Guid bookId, Guid basketId)
        {
            BookId = bookId;
            BasketId = basketId;            
        }
    }
}
