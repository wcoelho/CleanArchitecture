namespace Ativ5.Application.UseCases.AddBasket
{
    using System.Threading.Tasks;
    using Ativ5.Domain.Customers;
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using Ativ5.Application.Outputs;

    public class AddBasketInteractor : IInputBoundary<AddBasketInput>
    {
        private readonly ICustomerReadOnlyRepository customerReadOnlyRepository;
        private readonly IBasketWriteOnlyRepository basketWriteOnlyRepository;
        private readonly IOutputBoundary<AddBasketOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;
        
        public AddBasketInteractor(
            ICustomerReadOnlyRepository customerReadOnlyRepository,
            IBasketWriteOnlyRepository basketWriteOnlyRepository,
            IOutputBoundary<AddBasketOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.customerReadOnlyRepository = customerReadOnlyRepository;
            this.basketWriteOnlyRepository = basketWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(AddBasketInput input)
        {
            Customer customer = await customerReadOnlyRepository.Get(input.CustomerId);
            if (customer == null)
                throw new CustomerNotFoundException($"The customer {input.CustomerId} does not exist or it was not processed yet.");

            Basket basket = new Basket(customer.Id);            

            await basketWriteOnlyRepository.Add(basket);

            CustomerOutput customerOutput = outputConverter.Map<CustomerOutput>(customer);
            BasketOutput basketOutput = outputConverter.Map<BasketOutput>(basket);

            AddBasketOutput output = new AddBasketOutput(customerOutput, basketOutput);

            outputBoundary.Populate(output);
        }
    }
}
