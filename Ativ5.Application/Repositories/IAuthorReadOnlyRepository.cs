namespace Ativ5.Application.Repositories
{
    using Ativ5.Domain.Baskets;
    using System;
    using System.Threading.Tasks;

    public interface IAuthorReadOnlyRepository
    {
        Task<Author> Get(Guid id);        
    }
}
