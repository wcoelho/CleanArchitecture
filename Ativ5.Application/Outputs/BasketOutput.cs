namespace Ativ5.Application.Outputs
{
    using System;
    using System.Collections.Generic;

    public class BasketOutput
    {
        public Guid BasketId { get; private set; }        
        public Guid CustomerId { get; private set; }
        public double TotalPrice { get; private set; }
        public IReadOnlyList<BookOutput> Books { get; private set; }

        public BasketOutput()
        {

        }

        public BasketOutput(Guid basketId, Guid customerId, double totalPrice, List<BookOutput> books)
        {
            BasketId = basketId;
            CustomerId = customerId;
            TotalPrice = totalPrice;
            Books = books;
        }
    }
}
