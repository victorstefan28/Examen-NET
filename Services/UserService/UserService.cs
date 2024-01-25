using AutoMapper;
using Examen.Models.nsUser;
using Examen.Models.nsUser.DTO;
using Examen.Repositories.UserRepository;

namespace Examen.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await _userRepository.GetAllAsync();
        }

        public async Task<User> GetUserByIdAsync(Guid userId)
        {
            return await _userRepository.GetByIdAsync(userId);
        }

        public async Task<User> CreateUserAsync(CreateUserDTO createUserDto)
        {
            if (createUserDto == null)
            {
                throw new ArgumentNullException(nameof(createUserDto));
            }
            var userEntity = _mapper.Map<User>(createUserDto);
            await _userRepository.AddAsync(userEntity);

            return userEntity;
        }



    }

}
