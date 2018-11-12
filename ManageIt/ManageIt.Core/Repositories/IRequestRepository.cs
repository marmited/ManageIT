using ManageIt.Core.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageIt.Repositories
{
    public interface IRequestRepository
    {
        Task<Request> GetByIdAsync(int id);
        Task AddAsync(Request request);
        Task<IEnumerable<Request>> GetAllAsync();
    }
}
