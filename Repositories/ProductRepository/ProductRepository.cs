using Examen.Models.nsProduct;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.ProductRepository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext context) : base(context)
        {

        }
    }

}
