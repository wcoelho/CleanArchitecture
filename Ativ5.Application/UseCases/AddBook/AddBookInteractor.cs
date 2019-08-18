namespace Ativ5.Application.UseCases.AddBook
{
    using System.Threading.Tasks;
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using Ativ5.Application.Outputs;

    public class AddBookInteractor : IInputBoundary<AddBookInput>
    {
        private readonly IBookReadOnlyRepository bookReadOnlyRepository;
        private readonly IBookWriteOnlyRepository bookWriteOnlyRepository;
        private readonly IBasketReadOnlyRepository basketReadOnlyRepository;
        private readonly IBasketWriteOnlyRepository basketWriteOnlyRepository;

        private readonly IOutputBoundary<AddBookOutput> outputBoundary;
        private readonly IOutputConverter outputConverter;

        public AddBookInteractor(
            IBookReadOnlyRepository bookReadOnlyRepository,
            IBookWriteOnlyRepository bookWriteOnlyRepository,
            IBasketReadOnlyRepository basketReadOnlyRepository,
            IBasketWriteOnlyRepository basketWriteOnlyRepository,
            IOutputBoundary<AddBookOutput> outputBoundary,
            IOutputConverter outputConverter)
        {
            this.bookReadOnlyRepository = bookReadOnlyRepository;
            this.bookWriteOnlyRepository = bookWriteOnlyRepository;
            this.basketReadOnlyRepository = basketReadOnlyRepository;
            this.basketWriteOnlyRepository = basketWriteOnlyRepository;
            this.outputBoundary = outputBoundary;
            this.outputConverter = outputConverter;
        }

        public async Task Process(AddBookInput input)
        {
            Book book = await bookReadOnlyRepository.Get(input.BookId);
            if (book == null)
                throw new BookNotFoundException($"The book {input.BookId} does not exist.");

            Basket basket = (input.BasketId!=null)? await basketReadOnlyRepository.Get(input.BasketId):new Basket();

            Addition addition = new Addition(book.Id);
            basket.AddBook(addition);

            await basketWriteOnlyRepository.Update(basket);

            OrderOutput orderResponse = outputConverter.Map<OrderOutput>(addition);
            AddBookOutput output = new AddBookOutput(orderResponse, basket.GetTotalPrice().Value);

            outputBoundary.Populate(output);
        }
    }
}
