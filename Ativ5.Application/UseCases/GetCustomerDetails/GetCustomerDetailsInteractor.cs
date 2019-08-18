namespace Ativ5.Application.UseCases.GetCustomerDetails
{
    using System.Threading.Tasks;
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Customers;
    using System.Collections.Generic;
    using Ativ5.Application.Outputs;
    using Ativ5.Domain.Orders;

    public class GetCustomerDetailsInteractor : IInputBoundary<GetCustomerDetailsInput>
    {
        private readonly ICustomerReadOnlyRepository customerReadOnlyRepository;
        private readonly IOrderReadOnlyRepository orderReadOnlyRepository;
        private readonly IBasketReadOnlyRepository basketReadOnlyRepository;
        private readonly IOutputBoundary<CustomerOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public GetCustomerDetailsInteractor(
            ICustomerReadOnlyRepository customerReadOnlyRepository,
            IOrderReadOnlyRepository orderReadOnlyRepository,
            IBasketReadOnlyRepository basketReadOnlyRepository,
            IOutputBoundary<CustomerOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.customerReadOnlyRepository = customerReadOnlyRepository;
            this.orderReadOnlyRepository = orderReadOnlyRepository;
            this.basketReadOnlyRepository = basketReadOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(GetCustomerDetailsInput input)
        {

            Customer customer = await customerReadOnlyRepository.Get(input.CustomerId);

            if (customer == null)
                throw new CustomerNotFoundException($"The customer {input.CustomerId} does not exist or it was not processed yet.");

            List<Order> orders = await orderReadOnlyRepository.GetByCustomer(input.CustomerId);
            List<OrderOutput> orderOutputs = new List<OrderOutput>();

            if (orders.Count == 0)
                throw new CustomerNotFoundException($"No order found for customer {input.CustomerId}.");
            else
            {
                foreach(var item in orders)
                {
                    OrderOutput orderOutput= outputConverter.Map<OrderOutput>(item);
                    orderOutputs.Add(orderOutput);
                }
            }
           

            CustomerOutput output = outputConverter.Map<CustomerOutput>(customer);            

            output = new CustomerOutput(customer.Id, customer.PIN.Text, customer.Name.Text, orderOutputs);

            outputBoundary.Populate(output);
        }
    }
}