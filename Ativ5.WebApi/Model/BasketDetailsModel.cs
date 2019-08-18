namespace Ativ5.WebApi.Model
{
    using System;
    using System.Collections.Generic;

    public class BasketDetailsModel
    {
        public Guid BasketId { get; }
        public double TotalPrice { get; }
        public List<BookDetailsModel> Books { get; }

        public BasketDetailsModel(Guid basketId, double totalPrice, List<BookDetailsModel> books)
        {
            BasketId = basketId;
            TotalPrice = totalPrice;
            Books = books;
        }
    }
}
