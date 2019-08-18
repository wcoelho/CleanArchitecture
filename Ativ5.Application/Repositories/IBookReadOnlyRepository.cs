namespace Ativ5.Application.Repositories
{
    using Ativ5.Domain.Baskets;
    using System;
    using System.Threading.Tasks;

    public interface IBookReadOnlyRepository
    {
        Task<Book> Get(Guid id);        
    }
}
