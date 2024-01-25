using AutoMapper;
using Examen.Models.nsProduct;
using Examen.Models.nsProduct.DTO;
using Examen.Repositories.ProductRepository;

namespace Examen.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<Product> GetProductByIdAsync(Guid productId)
        {
            return await _productRepository.GetByIdAsync(productId);
        }

        public async Task<Product> CreateProductAsync(CreateProductDto createProductDto)
        {
            var productEntity = _mapper.Map<Product>(createProductDto);
            await _productRepository.AddAsync(productEntity);

            return _mapper.Map<Product>(productEntity);
        }
        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }
    }
}
