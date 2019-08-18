namespace Ativ5.Infrastructure.MongoDataAccess
{
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using MongoDB.Driver;
    using System;
    using System.Threading.Tasks;

    public class BasketRepository : IBasketReadOnlyRepository, IBasketWriteOnlyRepository
    {
        private readonly Context mongoContext;

        public BasketRepository(Context mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public async Task Add(Basket basket)
        {
            await mongoContext.Baskets.InsertOneAsync(basket);
        }

        public async Task Delete(Basket basket)
        {
            await mongoContext.Baskets.DeleteOneAsync(e => e.Id == basket.Id);
        }

        public async Task<Basket> Get(Guid id)
        {
            return await mongoContext
                .Baskets
                .Find(e => e.Id == id)
                .SingleOrDefaultAsync();
        }

        public async Task Update(Basket basket)
        {
            await mongoContext.Baskets.ReplaceOneAsync(e => e.Id == basket.Id, basket);
        }
    }
}
