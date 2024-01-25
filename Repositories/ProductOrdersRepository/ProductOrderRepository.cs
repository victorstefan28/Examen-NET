using Examen.Models.nsOrderProduct;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.ProductOrdersRepository
{
    public class OrderProductRepository : GenericRepository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
