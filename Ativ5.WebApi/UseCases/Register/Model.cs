namespace Ativ5.WebApi.UseCases.Register
{
    using System;
    using Ativ5.WebApi.Model;

    public class Model
    {
        public Guid CustomerId { get; }
        public string Personnummer { get; }
        public string Name { get; }


        public Model(
            Guid customerId,
            string perssonnummer,
            string name)
        {
            CustomerId = customerId;
            Personnummer = perssonnummer;
            Name = name;
        }
    }
}
