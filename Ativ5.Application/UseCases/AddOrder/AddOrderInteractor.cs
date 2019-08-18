namespace Ativ5.Application.UseCases.AddOrder
{
    using System.Threading.Tasks;
    using Ativ5.Domain.Customers;
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using Ativ5.Application.Outputs;

    public class AddOrderInteractor : IInputBoundary<AddOrderInput>
    {
        private readonly ICustomerReadOnlyRepository customerReadOnlyRepository;
        private readonly IBasketReadOnlyRepository basketReadOnlyRepository;
        private readonly IOutputBoundary<AddOrderOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;
        
        public AddOrderInteractor(
            ICustomerReadOnlyRepository customerReadOnlyRepository,
            IBasketReadOnlyRepository basketReadOnlyRepository,
            IOutputBoundary<AddOrderOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.customerReadOnlyRepository = customerReadOnlyRepository;
            this.basketReadOnlyRepository = basketReadOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(AddOrderInput input)
        {
            Customer customer = await customerReadOnlyRepository.Get(input.CustomerId);
            if (customer == null)
                throw new CustomerNotFoundException($"The customer {input.CustomerId} does not exist or it was not processed yet.");

            Basket basket = await basketReadOnlyRepository.Get(input.BasketId);
            if (basket == null)
                throw new BasketNotFoundException($"The basket {input.BasketId} does not exist or it was already deleted.");

            CustomerOutput customerOutput = outputConverter.Map<CustomerOutput>(customer);
            BasketOutput basketOutput = outputConverter.Map<BasketOutput>(basket);

            AddOrderOutput output = new AddOrderOutput(customerOutput, basketOutput, input.OrderDate, basket.GetTotalPrice().Value);

            outputBoundary.Populate(output);
        }
    }
}
