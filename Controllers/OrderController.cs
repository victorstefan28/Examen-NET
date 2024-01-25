using Examen.Models.nsOrder.DTO;

using Examen.Services.OrderService;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllOrders()
        {
            var orders = await _orderService.GetAllOrdersAsync();
            if (orders == null)
            {
                return NotFound();
            }
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrder(Guid id)
        {
            try
            {
                var order = await _orderService.GetOrderByIdAsync(id);
                if (order == null)
                {
                    return NotFound($"Order with id {id} not found.");
                }
                return Ok(order);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "An error occurred while retrieving the order." + ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrder([FromBody] CreateOrderDto createOrderDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var newOrder = await _orderService.CreateOrderAsync(createOrderDto);
                return Ok(newOrder);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An error occurred while creating the order." + ex);
            }
        }

        [HttpPost("assign-product")]
        public async Task<IActionResult> AssignProductToOrder([FromBody] AssignProductDTO assignProductDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _orderService.AssignProductToOrderAsync(assignProductDto);
                if (result == null)
                {
                    return BadRequest("Failed to assign product to order. The order or product may not exist, or they may already be linked.");
                }
                return Ok(result);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "An error occurred while assigning the product to the order.");
            }
        }
    }
}
