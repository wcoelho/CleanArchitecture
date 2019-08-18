namespace Ativ5.Application.UseCases.AddBasket
{
    using System;
    using System.Collections.Generic;
    using Ativ5.Domain.Baskets;

    public class AddBasketInput
    {
        public Guid CustomerId { get; private set; }

        public List<Book> Books { get; private set; }


        public AddBasketInput(Guid customerId, List<Book> books)
        {
            this.CustomerId = customerId;
            this.Books = books;
        }
    }
}
