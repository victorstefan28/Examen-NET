using Examen.Models.Base;
using Examen.Models.nsOrder;

namespace Examen.Models.nsUser
{
    public class User : BaseEntity
    {

        public string Name { get; set; }
        public string Email { get; set; }
        // Relație one-to-many cu Order
        public ICollection<Order> Orders { get; set; }
    }
}
