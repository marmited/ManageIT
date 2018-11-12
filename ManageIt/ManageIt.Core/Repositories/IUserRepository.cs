﻿using ManageIt.Core.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ManageIt.Repositories
{
    public interface IUserRepository
    {
        Task<User> GetByIdAsync(int id);
        Task<User> GetByEmailAsync(string email);
        Task AddAsync(User user);
        Task<IEnumerable<User>> GetAllAsync();
    }
}
