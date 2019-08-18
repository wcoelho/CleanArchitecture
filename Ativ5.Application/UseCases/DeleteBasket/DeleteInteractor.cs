namespace Ativ5.Application.UseCases.DeleteBasket
{
    using System.Threading.Tasks;
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;

    public class DeleteInteractor : IInputBoundary<DeleteInput>
    {
        private readonly IBasketReadOnlyRepository basketReadOnlyRepository;
        private readonly IBasketWriteOnlyRepository basketWriteOnlyRepository;
        private readonly IOutputBoundary<DeleteOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public DeleteInteractor(
            IBasketReadOnlyRepository basketReadOnlyRepository,
            IBasketWriteOnlyRepository basketWriteOnlyRepository,
            IOutputBoundary<DeleteOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.basketReadOnlyRepository = basketReadOnlyRepository;
            this.basketWriteOnlyRepository = basketWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(DeleteInput input)
        {
            Basket basket = await basketReadOnlyRepository.Get(input.BasketId);
			if (basket == null)
                throw new BasketNotFoundException($"The basket {input.BasketId} does not exist or it was already deleted.");

            await basketWriteOnlyRepository.Delete(basket);

            DeleteOutput output = outputConverter.Map<DeleteOutput>(basket);
            this.outputBoundary.Populate(output);
        }
    }
}