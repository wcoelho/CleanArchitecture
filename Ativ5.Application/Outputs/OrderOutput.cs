namespace Ativ5.Application.Outputs
{
    using System;
    public class OrderOutput
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid BasketId { get; set; }
        public double FinalPrice { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
