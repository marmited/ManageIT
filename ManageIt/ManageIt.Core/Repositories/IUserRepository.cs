using ManageIt.Core.Context;
using System.Collections.Generic;

namespace ManageIt.Repositories
{
    public interface IUserRepository
    {
        User GetById(int id);
        void Add(User user);
        IEnumerable<User> GetAll();
    }
}
