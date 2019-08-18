namespace Ativ5.Domain.Baskets
{
    using Ativ5.Domain.ValueObjects;
    using System;

    public class Removal : Book
    {
        protected Removal()
        {

        }

        public Removal(Guid bookId)
            : base(bookId)
        {

        }

    }
}
