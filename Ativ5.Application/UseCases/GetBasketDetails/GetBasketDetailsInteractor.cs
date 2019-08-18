namespace Ativ5.Application.UseCases.GetBasketDetails
{
    using System.Threading.Tasks;
    using Ativ5.Application.Repositories;
    using Ativ5.Application.Outputs;

    public class GetBasketDetailsInteractor : IInputBoundary<GetBasketDetailsInput>
    {
        private readonly IBasketReadOnlyRepository basketReadOnlyRepository;
        private readonly IOutputBoundary<BasketOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public GetBasketDetailsInteractor(
            IBasketReadOnlyRepository basketReadOnlyRepository,
            IOutputBoundary<BasketOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.basketReadOnlyRepository = basketReadOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(GetBasketDetailsInput input)
        {
            var basket = await basketReadOnlyRepository.Get(input.BasketId);
            if (basket == null)
            {
                outputBoundary.Populate(null);
                return;
            }

            BasketOutput output = outputConverter.Map<BasketOutput>(basket);
            outputBoundary.Populate(output);
        }
    }
}
