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
        public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }

    }
}
