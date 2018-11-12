using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageIt.Core.Context;
using ManageIt.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ManageIt.Infrastructure.Repositories
{
    class RequestRepository : IRequestRepository
    {
        protected readonly DbSet<Request> _dbset;

        public RequestRepository(ManageItDbContext context)
        {
            _dbset = context.Set<Request>();
        }
        public async Task AddAsync(Request request)
        {
            await _dbset.AddAsync(request);
        }

        public async Task<IEnumerable<Request>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<Request> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }
    }
}
