using System.Threading.Tasks;
using TrackFlow.Application.Interfaces.IRepository;
using TrackFlow.Application.Interfaces.IService;
using TrackFlow.Domain.Entities;

namespace TrackFlow.Application.Services
{
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository) : base(userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _userRepository.GetByEmailAsync(email);
        }

        public async Task<bool> IsEmailUniqueAsync(string email, Guid? excludeUserId = null)
        {
            return await _userRepository.IsEmailUniqueAsync(email, excludeUserId);
        }
    }
}
