namespace Ativ5.Domain.Customers
{
    using System.Collections.Generic;
    using System;
    using System.Collections.ObjectModel;

    public class OrderCollection : Collection<Guid>
    {
        public OrderCollection()
        {

        }

        public OrderCollection(IEnumerable<Guid> list)
        {
            foreach (var item in list)
            {
                Items.Add(item);
            }
        }
    }
}
