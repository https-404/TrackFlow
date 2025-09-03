using System.Threading.Tasks;
using TrackFlow.Domain.Entities;

namespace TrackFlow.Application.Interfaces.IService
{
    public interface IUserService : IService<User>
    {
        Task<User?> GetByEmailAsync(string email);
        Task<bool> IsEmailUniqueAsync(string email, Guid? excludeUserId = null);
    }
}
