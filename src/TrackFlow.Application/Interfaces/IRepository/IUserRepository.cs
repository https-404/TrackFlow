using System.Threading.Tasks;
using TrackFlow.Domain.Entities;

namespace TrackFlow.Application.Interfaces.IRepository
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
        Task<bool> IsEmailUniqueAsync(string email, Guid? excludeUserId = null);
    }
}
