namespace Ativ5.Application.UseCases.Register
{
    using Ativ5.Application.Outputs;
    public class RegisterOutput
    {
        public CustomerOutput Customer { get; private set; }

        public RegisterOutput()
        {

        }

        public RegisterOutput(CustomerOutput customer)
        {
            Customer = customer;
        }
    }
}
