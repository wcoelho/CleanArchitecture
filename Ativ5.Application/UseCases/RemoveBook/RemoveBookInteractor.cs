namespace Ativ5.Application.UseCases.RemoveBook
{
    using System.Threading.Tasks;
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using Ativ5.Application.Outputs;

    public class RemoveBookInteractor : IInputBoundary<RemoveBookInput>
    {
        private readonly IBookReadOnlyRepository bookReadOnlyRepository;
        private readonly IBookWriteOnlyRepository bookWriteOnlyRepository;
        private readonly IBasketReadOnlyRepository basketReadOnlyRepository;
        private readonly IBasketWriteOnlyRepository basketWriteOnlyRepository;

        private readonly IOutputBoundary<RemoveBookOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public RemoveBookInteractor(
            IBookReadOnlyRepository bookReadOnlyRepository,
            IBookWriteOnlyRepository bookWriteOnlyRepository,
            IBasketReadOnlyRepository basketReadOnlyRepository,
            IBasketWriteOnlyRepository basketWriteOnlyRepository,
            IOutputBoundary<RemoveBookOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.bookReadOnlyRepository = bookReadOnlyRepository;
            this.bookWriteOnlyRepository = bookWriteOnlyRepository;
            this.basketReadOnlyRepository = basketReadOnlyRepository;
            this.basketWriteOnlyRepository = basketWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(RemoveBookInput input)
        {
            Book book = await bookReadOnlyRepository.Get(input.BookId);
            if (book == null)
                throw new BookNotFoundException($"The book {input.BookId} does not exist.");

            Basket basket = (input.BasketId!=null)? await basketReadOnlyRepository.Get(input.BasketId):new Basket();

            Removal removal = new Removal(book.Id);
            basket.RemoveBook(removal);

            await basketWriteOnlyRepository.Update(basket);

            OrderOutput orderResponse = outputConverter.Map<OrderOutput>(removal);
            RemoveBookOutput output = new RemoveBookOutput(orderResponse, basket.GetTotalPrice().Value);

            outputBoundary.Populate(output);
        }
    }
}
