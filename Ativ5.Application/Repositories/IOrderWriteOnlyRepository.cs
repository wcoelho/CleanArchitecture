namespace Ativ5.Application.Repositories
{
    using Ativ5.Domain.Orders;
    using System.Threading.Tasks;

    public interface IOrderWriteOnlyRepository
    {
        Task Add(Order order);
        Task Update(Order order);        
    }
}