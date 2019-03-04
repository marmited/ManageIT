using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ManageIt.Core.Context
{
    public class ManageItDbContext : DbContext
    {
        public ManageItDbContext(DbContextOptions options) : base(options)
        {
        }
        public ManageItDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().Where(e => !e.IsOwned()).SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Correspondence> Correspondences { get; set; }
        public DbSet<Message> Messages { get; set; }


    }
}
