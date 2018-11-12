using ManageIt.Core.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageIt.Repositories
{
    public interface ITimeSlotRepository
    {
        Task<TimeSlot> GetByIdAsync(int id);
        Task AddAsync(TimeSlot timeSlot);
        Task<IEnumerable<TimeSlot>> GetAllAsync();
    }
}
