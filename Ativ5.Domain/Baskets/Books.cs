namespace Ativ5.Domain.Baskets
{
    using System;
    using Ativ5.Domain.ValueObjects;

    public class Book : Entity
    {
        public virtual ISBN ISBN { get; protected set; }
        public virtual Title Title { get; protected set; }        
        public virtual double Price { get; protected set; }
        public virtual AuthorCollection Authors { get; protected set; }

        protected Book()
        {
            Authors = new AuthorCollection();
        }
        public Book(Guid bookId)
            : this()
        {
           Id = bookId;
        }

        public Book(ISBN isbn, Title title, double price)
            : this()
        {
            ISBN = isbn;
            Title = title;
            Price = price;
        }

        public virtual void Register(Guid authorId)
        {
            Authors = new AuthorCollection();
            Authors.Add(authorId);
        }
    }
}
