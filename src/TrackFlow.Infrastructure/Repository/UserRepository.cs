using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrackFlow.Application.Interfaces.IRepository;
using TrackFlow.Domain.Entities;
using TrackFlow.Infrastructure.Data;

namespace TrackFlow.Infrastructure.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<User?> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<bool> IsEmailUniqueAsync(string email, Guid? excludeUserId = null)
        {
            Expression<Func<User, bool>> predicate;

            if (excludeUserId.HasValue)
            {
                predicate = u => u.Email == email && u.Id != excludeUserId.Value;
            }
            else
            {
                predicate = u => u.Email == email;
            }

            return !await _context.Users.AnyAsync(predicate);
        }
    }
}
