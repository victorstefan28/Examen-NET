namespace Examen.Models
{
    public class OrderDTO
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }

        public List<OrderProductDTO> OrderProducts { get; set; }
    }

    public class OrderProductDTO
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public ProductDTO Product { get; set; }
    }

    public class ProductDTO
    {
        public Guid Id { get; set; }
        public string Nume { get; set; }
        public string Descriere { get; set; }

    }
}
