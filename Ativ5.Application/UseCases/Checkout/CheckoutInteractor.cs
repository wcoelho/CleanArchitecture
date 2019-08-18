namespace Ativ5.Application.UseCases.Checkout
{
    using System.Threading.Tasks;
    using Ativ5.Domain.Customers;
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using Ativ5.Application.Outputs;

    public class CheckoutInteractor : IInputBoundary<CheckoutInput>
    {
        private readonly ICustomerReadOnlyRepository customerReadOnlyRepository;
        private readonly IBasketReadOnlyRepository basketReadOnlyRepository;
        private readonly IOutputBoundary<CheckoutOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;
        
        public CheckoutInteractor(
            ICustomerReadOnlyRepository customerReadOnlyRepository,
            IBasketReadOnlyRepository basketReadOnlyRepository,
            IOutputBoundary<CheckoutOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.customerReadOnlyRepository = customerReadOnlyRepository;
            this.basketReadOnlyRepository = basketReadOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(CheckoutInput input)
        {
            Customer customer = await customerReadOnlyRepository.Get(input.CustomerId);
            if (customer == null)
                throw new CustomerNotFoundException($"The customer {input.CustomerId} does not exist or it was not processed yet.");

            Basket basket = await basketReadOnlyRepository.Get(input.BasketId);
            if (basket == null)
                throw new BasketNotFoundException($"The basket {input.BasketId} does not exist or it was already deleted.");

            CustomerOutput customerOutput = outputConverter.Map<CustomerOutput>(customer);
            BasketOutput basketOutput = outputConverter.Map<BasketOutput>(basket);

            CheckoutOutput output = new CheckoutOutput(customerOutput, basketOutput, input.OrderDate, basket.GetTotalPrice().Value);

            outputBoundary.Populate(output);
        }
    }
}
