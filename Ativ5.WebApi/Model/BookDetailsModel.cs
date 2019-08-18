namespace Ativ5.WebApi.Model
{
    using System;
    using System.Collections.Generic;

    public class BookDetailsModel
    {
        public Guid BookId { get; }
        public double Price { get; }
        public string ISBN { get; }
        public string Title { get; }
        public List<AuthorDetailsModel> Authors { get; }

        public BookDetailsModel(Guid bookId, double price, string isbn, string title, List<AuthorDetailsModel> authors)
        {
            BookId = bookId;
            Price = price;
            ISBN = isbn;
            Title = title;
            Authors = authors;
        }
    }
}
