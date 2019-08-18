namespace Ativ5.Application.UseCases.Register
{
    using System.Threading.Tasks;
    using Ativ5.Domain.Customers;
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using Ativ5.Application.Outputs;

    public class RegisterInteractor : IInputBoundary<RegisterInput>
    {
        private readonly ICustomerWriteOnlyRepository customerWriteOnlyRepository;
        private readonly IBasketWriteOnlyRepository basketWriteOnlyRepository;
        private readonly IOutputBoundary<RegisterOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;
        
        public RegisterInteractor(
            ICustomerWriteOnlyRepository customerWriteOnlyRepository,
            IBasketWriteOnlyRepository basketWriteOnlyRepository,
            IOutputBoundary<RegisterOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.customerWriteOnlyRepository = customerWriteOnlyRepository;
            this.basketWriteOnlyRepository = basketWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(RegisterInput input)
        {
            Customer customer = new Customer(input.PIN, input.Name);

            await customerWriteOnlyRepository.Add(customer);

            CustomerOutput customerOutput = outputConverter.Map<CustomerOutput>(customer);

            RegisterOutput output = new RegisterOutput(customerOutput);

            outputBoundary.Populate(output);
        }
    }
}
