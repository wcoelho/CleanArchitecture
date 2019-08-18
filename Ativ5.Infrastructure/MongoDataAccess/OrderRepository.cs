namespace Ativ5.Infrastructure.MongoDataAccess
{
    using Ativ5.Application.Repositories;
    using Ativ5.Domain.Baskets;
    using MongoDB.Driver;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class OrderRepository : IOrderReadOnlyRepository, IOrderWriteOnlyRepository
    {
        private readonly Context mongoContext;

        public OrderRepository(Context mongoContext)
        {
            this.mongoContext = mongoContext;
        }

        public async Task<Order> Get(Guid orderId)
        {
            Order order = await mongoContext.Orders
                .Find(e => e.Id == orderId)
                .SingleOrDefaultAsync();

            return order;
        }

        public async Task<List<Order>> GetByCustomer(Guid customerId)
        {
            List<Order> orders = await mongoContext.Orders
                .Find(e => e.CustomerId == customerId)
                .ToListAsync();

            return orders;
        }

        public async Task Add(Order order)
        {
            await mongoContext.Orders
                .InsertOneAsync(order);
        }

        public async Task Delete(Order order)
        {
            await mongoContext.Orders
                .DeleteOneAsync(e => e.Id == order.Id);
        }

        public async Task Update(Order order)
        {
            await mongoContext.Orders
                .ReplaceOneAsync(e => e.Id == order.Id, order);
        }
    }
}
