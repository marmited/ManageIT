using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ManageIt.Core.Context
{
    public class ManageItDbContext : DbContext
    {
        public ManageItDbContext(DbContextOptions options) : base(options)
        {
        }
        private DbSet<User> Users { get; set; }
        private DbSet<Request> Requests { get; set; }
        private DbSet<TimeSlot> TimeSlots { get; set; }

    }
}
