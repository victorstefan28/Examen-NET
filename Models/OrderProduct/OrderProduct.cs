using Examen.Models.Base;
using Examen.Models.nsOrder;
using Examen.Models.nsProduct;

namespace Examen.Models.nsOrderProduct
{
    public class OrderProduct : BaseEntity
    {
        public Guid OrderId { get; set; }
        public Order Order { get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
