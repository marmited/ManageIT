using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void Add(User user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _dbset.ToList();
        }

        public User GetById(int id)
        {
            return _dbset.Find(id);
        }
    }
}
