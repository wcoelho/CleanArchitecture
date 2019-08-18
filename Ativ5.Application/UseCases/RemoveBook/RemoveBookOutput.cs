namespace Ativ5.Application.UseCases.RemoveBook
{
    using Ativ5.Application.Outputs;
    public class RemoveBookOutput
    {
        public OrderOutput Order { get; private set; }
        public double UpdatedTotalPrice { get; private set; }

        public RemoveBookOutput()
        {

        }

        public RemoveBookOutput(OrderOutput order, double updatedTotalPrice)
        {
            this.Order = order;
            this.UpdatedTotalPrice = updatedTotalPrice;
        }
    }
}
