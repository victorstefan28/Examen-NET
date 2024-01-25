using Examen.Models.nsUser;
using Examen.Repositories.GenericRepository;

namespace Examen.Repositories.UserRepository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        {

        }

    }
}
