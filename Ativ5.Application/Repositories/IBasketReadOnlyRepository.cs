namespace Ativ5.Application.Repositories
{
    using Ativ5.Domain.Baskets;
    using System;
    using System.Threading.Tasks;

    public interface IBasketReadOnlyRepository
    {
        Task<Basket> Get(Guid id);        
    }
}
