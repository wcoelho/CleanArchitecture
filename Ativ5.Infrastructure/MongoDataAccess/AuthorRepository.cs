namespace Ativ5.Infrastructure.MongoDataAccess
{
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using MongoDB.Driver;
    using System;
    using System.Threading.Tasks;

    public class AuthorRepository : IAuthorReadOnlyRepository, IAuthorWriteOnlyRepository
    {
        private readonly Context mongoContext;

        public AuthorRepository(Context mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public async Task<Author> Get(Guid authorId)
        {
            Author author = await mongoContext.Authors
                .Find(e => e.Id == authorId)
                .SingleOrDefaultAsync();

            return author;
        }

        public async Task Add(Author author)
        {
            await mongoContext.Authors
                .InsertOneAsync(author);
        }

        public async Task Delete(Author author)
        {
            await mongoContext.Authors
                .DeleteOneAsync(e => e.Id == author.Id);
        }

        public async Task Update(Author author)
        {
            await mongoContext.Authors
                .ReplaceOneAsync(e => e.Id == author.Id, author);
        }
    }
}
