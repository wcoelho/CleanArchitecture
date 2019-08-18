namespace Ativ5.WebApi.UseCases.RemoveBook
{
    using System;
    public class RemoveBookRequest
    {
        public Guid BookId { get; set; }
        public Guid BasketId { get; set; }
       
    }
}