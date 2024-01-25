using Examen.Models.Base;
using Examen.Models.nsOrderProduct;
using Examen.Models.nsUser;

namespace Examen.Models.nsOrder
{
    public class Order : BaseEntity
    {

        public DateTime Date { get; set; }
        // Foreign Key
        public Guid UserId { get; set; }
        // Relație one-to-many cu User
        public User UserInstnace { get; set; }
        // Relație many-to-many cu Product prin tabela OrderProduct
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }

}
