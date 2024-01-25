using AutoMapper;
using Examen.Models;
using Examen.Models.nsOrder;
using Examen.Models.nsOrder.DTO;
using Examen.Models.nsOrderProduct;

using Examen.Repositories.OrderRepository;
using Examen.Repositories.ProductOrdersRepository;
using Examen.Repositories.ProductRepository;

namespace Examen.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IProductRepository _productRepository;
        private readonly IOrderProductRepository _orderProductRepository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository orderRepository, IProductRepository productRepository, IOrderProductRepository orderProductRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _productRepository = productRepository;
            _orderProductRepository = orderProductRepository;
            _mapper = mapper;
        }

        public async Task<OrderDTO> GetOrderByIdAsync(Guid orderId)
        {
            var order = await _orderRepository.GetByIdAsync(orderId);
            var orderDto = _mapper.Map<OrderDTO>(order);
            if (orderDto == null)
            {
                return null;
            }
            return orderDto;

        }

        public async Task<Order> CreateOrderAsync(CreateOrderDto createOrderDto)
        {
            var orderEntity = _mapper.Map<Order>(createOrderDto);
            await _orderRepository.AddAsync(orderEntity);


            return _mapper.Map<Order>(orderEntity);
        }
        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {

            var orders = await _orderRepository.GetAllOrdersWithDetailsAsync();
            return orders;
        }


        public async Task<OrderProduct> AssignProductToOrderAsync(AssignProductDTO assignProductDto)
        {
            // Check if order and product exist
            var order = await _orderRepository.GetByIdAsync(assignProductDto.OrderId);
            var product = await _productRepository.GetByIdAsync(assignProductDto.ProductId);

            if (order == null || product == null)
            {
                return null;
            }


            var orderProduct = new OrderProduct
            {
                OrderId = assignProductDto.OrderId,
                ProductId = assignProductDto.ProductId
            };




            return _mapper.Map<OrderProduct>(orderProduct);
        }


    }
}
