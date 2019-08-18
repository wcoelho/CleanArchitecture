namespace Ativ5.Application.Repositories
{
    using Ativ5.Domain.Baskets;
    using System;
    using System.Threading.Tasks;
    using System.Collections.Generic;
    public interface IOrderReadOnlyRepository
    {
        Task<Order> Get(Guid id);   

        Task<List<Order>> GetByCustomer(Guid customerId);     
    }
}
