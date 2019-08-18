namespace Ativ5.Infrastructure.MongoDataAccess
{
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using MongoDB.Driver;
    using System;
    using System.Threading.Tasks;

    public class BookRepository : IBookReadOnlyRepository, IBookWriteOnlyRepository
    {
        private readonly Context mongoContext;

        public BookRepository(Context mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public async Task Add(Book book)
        {
            await mongoContext.Books.InsertOneAsync(book);
        }

        public async Task Delete(Book book)
        {
            await mongoContext.Books.DeleteOneAsync(e => e.Id == book.Id);
        }

        public async Task<Book> Get(Guid id)
        {
            return await mongoContext
                .Books
                .Find(e => e.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task Update(Book book)
        {
            await mongoContext.Books.ReplaceOneAsync(e => e.Id == book.Id, book);
        }
    }
}
