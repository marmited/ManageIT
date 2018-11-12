using System.Threading.Tasks;
using ManageIt.Core.Repositories.UnitOfWork;
using ManageIt.Repositories;
using ManageIt.Core.Context;

namespace ManageIt.Infrastructure.Repositories.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ManageItDbContext _context;

        public UnitOfWork(ManageItDbContext context)
        {
            _context = context;
            Users = new UserRepository(_context);
            //Requests = new RequestRepository(_context);
            TimeSlots = new TimeSlotRepository(_context);
        }

        public IUserRepository Users { get; private set; }
        public IRequestRepository Requests { get; private set; }
        public ITimeSlotRepository TimeSlots { get; private set; }
        
        public void Complete()
        {
            _context.SaveChanges();
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
