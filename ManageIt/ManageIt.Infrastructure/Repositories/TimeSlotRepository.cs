using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void Add(TimeSlot timeSlot)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TimeSlot> GetAll()
        {
            return _dbset.ToList();
        }

        public TimeSlot GetById(int id)
        {
            return _dbset.Find(id);
        }
    }
}
