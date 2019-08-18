using Ativ5.Application.Outputs;

namespace Ativ5.Application.UseCases.AddBook
{
    public class AddBookOutput
    {
        public OrderOutput Order { get; private set; }
        public double UpdatedTotalPrice { get; private set; }
        public AddBookOutput()
        {

        }

        public AddBookOutput(OrderOutput order, double updatedTotalPrice)
        {
            Order = order;
            UpdatedTotalPrice = updatedTotalPrice;
        }
    }
}
