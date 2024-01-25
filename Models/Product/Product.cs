using Examen.Models.Base;
using Examen.Models.nsOrderProduct;

namespace Examen.Models.nsProduct
{
    public class Product : BaseEntity
    {
        public string Nume { get; set; }
        public string Descriere { get; set; }

        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
