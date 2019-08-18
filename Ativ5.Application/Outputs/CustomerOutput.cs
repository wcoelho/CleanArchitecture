namespace Ativ5.Application.Outputs
{
    using System;
    using System.Collections.Generic;

    public class CustomerOutput
    {
        public Guid CustomerId { get; private set; }
        public string Personnummer { get; private set; }
        public string Name { get; private set; }
        public IReadOnlyList<OrderOutput> Orders { get; private set; }

        public CustomerOutput()
        {

        }

        public CustomerOutput(
            Guid customerId,
            string personnummer,
            string name,
            List<OrderOutput> orders)
        {
            CustomerId = customerId;
            Personnummer = personnummer;
            Name = name;
            Orders = orders;
        }
    }
}
