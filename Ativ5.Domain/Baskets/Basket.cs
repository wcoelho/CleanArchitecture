namespace Ativ5.Domain.Baskets
{
    using Ativ5.Domain.ValueObjects;
    using System;

    public class Basket : Entity
    {
        public virtual Guid CustomerId { get; protected set; }
        public virtual BookCollection Books { get; protected set; }

        public Basket()
        {
            Books = new BookCollection();
        }

        public Basket(Guid customerId)
            : this()
        {
            CustomerId = customerId;
        }

        public void AddBook(Addition addition)
        {
            Books.Add(addition);
        }

        public void RemoveBook(Removal removal)
        {
             Books.Remove(removal);
        }

        public FinalPrice GetTotalPrice()
        {
            return Books.GetTotalPrice();
        }
    }
}
