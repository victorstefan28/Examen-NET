using Examen.Models;
using Examen.Models.nsOrder;
using Examen.Models.nsOrder.DTO;
using Examen.Models.nsOrderProduct;


namespace Examen.Services.OrderService
{
    public interface IOrderService
    {
        Task<OrderDTO> GetOrderByIdAsync(Guid orderId);
        Task<Order> CreateOrderAsync(CreateOrderDto createOrderDto);

        Task<IEnumerable<Order>> GetAllOrdersAsync();

        Task<OrderProduct> AssignProductToOrderAsync(AssignProductDTO assignProductDto);
    }
}
