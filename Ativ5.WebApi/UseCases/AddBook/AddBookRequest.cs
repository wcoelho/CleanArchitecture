namespace Ativ5.WebApi.UseCases.AddBook
{
    using System;
    public class AddBookRequest
    {
        public Guid BookId { get; set; }

        public Guid BasketId { get; set; }
    }
}
