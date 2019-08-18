namespace Ativ5.Application.Repositories
{
    using Ativ5.Domain.Baskets;
    using System.Threading.Tasks;

    public interface IBookWriteOnlyRepository
    {
        Task Add(Book book);
        Task Update(Book book);
        Task Delete(Book book);
    }
}
