namespace Ativ5.Domain.Baskets
{
    using Ativ5.Domain.ValueObjects;
    using System;

    public abstract class Order : Entity
    {
        public virtual Guid CustomerId { get; set; }
        public virtual Guid BasketId { get; set; }
        public virtual Amount Amount { get; protected set; }
        public virtual DateTime OrderDate { get; protected set; }

        protected Order()
        {

        }

        protected Order(Guid customerId, Guid basketId, Amount amount, DateTime orderDate)
        {
            CustomerId = customerId;
            BasketId = basketId;
            Amount = amount;
            OrderDate = orderDate;
        }
    }
}
