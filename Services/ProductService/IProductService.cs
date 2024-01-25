using Examen.Models.nsProduct;
using Examen.Models.nsProduct.DTO;

namespace Examen.Services.ProductService
{
    public interface IProductService
    {
        Task<Product> GetProductByIdAsync(Guid productId);
        Task<Product> CreateProductAsync(CreateProductDto createProductDto);

        Task<IEnumerable<Product>> GetAllProductsAsync();
    }
}
