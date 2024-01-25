using Examen.Models.nsUser;
using Examen.Models.nsUser.DTO;

namespace Examen.Services.UserService
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserByIdAsync(Guid userId);
        Task<User> CreateUserAsync(CreateUserDTO user);


    }

}
