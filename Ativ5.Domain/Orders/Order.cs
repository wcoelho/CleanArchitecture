namespace Ativ5.Domain.Orders
{
    using Ativ5.Domain.ValueObjects;
    using System;

    public abstract class Order : Entity
    {
        public virtual Guid CustomerId { get; set; }
        public virtual Guid BasketId { get; set; }
        public virtual FinalPrice FinalPrice { get; protected set; }
        public virtual DateTime OrderDate { get; protected set; }

        protected Order()
        {

        }

        protected Order(Guid customerId, Guid basketId, FinalPrice finalPrice, DateTime orderDate)
        {
            CustomerId = customerId;
            BasketId = basketId;
            FinalPrice = finalPrice;
            OrderDate = orderDate;
        }
    }
}
