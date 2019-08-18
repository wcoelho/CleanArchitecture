namespace Ativ5.Application.Repositories
{
    using Ativ5.Domain.Baskets;
    using System.Threading.Tasks;

    public interface IAuthorWriteOnlyRepository
    {
        Task Add(Author author);
        Task Update(Author author);
        Task Delete(Author author);
    }
}
