namespace Ativ5.Application.Repositories
{
    using Ativ5.Domain.Baskets;
    using System.Threading.Tasks;

    public interface IBasketWriteOnlyRepository
    {
        Task Add(Basket basket);
        Task Update(Basket basket);
        Task Delete(Basket basket);
    }
}
