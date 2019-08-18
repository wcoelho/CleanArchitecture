namespace Ativ5.Domain.Customers
{
    using Ativ5.Domain.ValueObjects;

    public class Customer : Entity
    {
        public virtual Name Name { get; protected set; }
        public virtual PIN PIN { get; protected set; }
        public virtual OrderCollection Orders { get; protected set; }

        protected Customer()
        {
            Orders = new OrderCollection();
        }

        public Customer(PIN pin, Name name)
            : this()
        {
            PIN = pin;
            Name = name;
        }

    }
}
