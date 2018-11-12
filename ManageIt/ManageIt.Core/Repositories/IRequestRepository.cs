using ManageIt.Core.Context;
using System.Collections.Generic;

namespace ManageIt.Repositories
{
    public interface IRequestRepository
    {
        Request GetById(int id);
        void Add(Request request);
        IEnumerable<Request> GetAll();
    }
}
