using System;
using System.Collections.Generic;

namespace Ativ5.WebApi.Model
{
    public class CustomerDetailsModel
    {
        public Guid CustomerId { get; }
        public string Personnummer { get; }
        public string Name { get; }

        public IReadOnlyList<OrderDetailsModel> Orders { get; }

        public CustomerDetailsModel(Guid customerId, string personnummer, string name, IReadOnlyList<OrderDetailsModel> orders)
        {
            CustomerId = customerId;
            Personnummer = personnummer;
            Name = name;
            Orders = orders;
        }
    }
}
