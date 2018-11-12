using ManageIt.Core.Context;
using System.Collections.Generic;

namespace ManageIt.Repositories
{
    public interface ITimeSlotRepository
    {
        TimeSlot GetById(int id);
        void Add(TimeSlot timeSlot);
        IEnumerable<TimeSlot> GetAll();
    }
}
