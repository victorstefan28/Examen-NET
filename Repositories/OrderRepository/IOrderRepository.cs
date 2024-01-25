using Examen.Models.nsOrder;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.OrderRepository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {

        Task<IEnumerable<Order>> GetAllOrdersWithDetailsAsync();
    }
}
