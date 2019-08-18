namespace Ativ5.Application.Outputs
{
    using System;
    using System.Collections.Generic;
    public class BookOutput
    {
        public Guid BookId { get; set; }
        public string ISBN { get; set; }
        public double Price { get; set; }
        public string Title { get; set; }
        public IReadOnlyList<AuthorOutput> Authors { get; private set; }
        public BookOutput()
        {

        }

        public BookOutput(Guid bookId, string isbn, double price, string title, List<AuthorOutput> authors)
        {
            BookId = bookId;
            ISBN = isbn;
            Price = price;
            Title = title;
            Authors = authors;
        }
    }
}
