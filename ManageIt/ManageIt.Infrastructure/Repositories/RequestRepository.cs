using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        public void Add(Request request)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Request> GetAll()
        {
            return _dbset.ToList();
        }

        public Request GetById(int id)
        {
            return _dbset.Find(id);
        }
    }
}
