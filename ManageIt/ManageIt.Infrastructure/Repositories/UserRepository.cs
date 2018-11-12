using System.Collections.Generic;
using System.Threading.Tasks;
using ManageIt.Core.Context;
using ManageIt.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ManageIt.Infrastructure.Repositories
{
    class UserRepository : IUserRepository
    {
        protected readonly DbSet<User> _dbset;

        public UserRepository(ManageItDbContext context)
        {
            _dbset = context.Set<User>();
        }
        public async Task AddAsync(User user)
        {
            await _dbset.AddAsync(user);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }
        public async Task<User> GetByEmailAsync(string email)
        {
            return await _dbset.SingleOrDefaultAsync(x=>x.Email == email);
        }
    }
}
