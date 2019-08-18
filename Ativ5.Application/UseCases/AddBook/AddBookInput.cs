namespace Ativ5.Application.UseCases.AddBook
{
    using System;

    public class AddBookInput
    {
        public Guid BookId { get; private set; }
        public Guid BasketId { get; private set; }

        public AddBookInput(Guid bookId, Guid basketId)
        {
            BookId = bookId;
            BasketId = basketId;
        }
    }
}
