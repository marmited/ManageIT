using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ManageIt.Repositories;

namespace ManageIt.Core.Repositories.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; }
        IRequestRepository Requests { get; }
        ITimeSlotRepository TimeSlots {get; }
        void Complete();
        Task CompleteAsync();
    }
}
