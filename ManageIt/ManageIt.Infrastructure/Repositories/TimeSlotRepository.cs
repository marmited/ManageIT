using System.Collections.Generic;
using System.Threading.Tasks;
using ManageIt.Core.Context;
using ManageIt.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ManageIt.Infrastructure.Repositories
{
    class TimeSlotRepository : ITimeSlotRepository
    {
        protected readonly DbSet<TimeSlot> _dbset;

        public TimeSlotRepository(ManageItDbContext context)
        {
            _dbset = context.Set<TimeSlot>();
        }
        public async Task AddAsync(TimeSlot timeSlot)
        {
            await _dbset.AddAsync(timeSlot);
        }

        public async Task<IEnumerable<TimeSlot>> GetAllAsync()
        {
            return await _dbset.ToListAsync();
        }

        public async Task<TimeSlot> GetByIdAsync(int id)
        {
            return await _dbset.FindAsync(id);
        }
    }
}
