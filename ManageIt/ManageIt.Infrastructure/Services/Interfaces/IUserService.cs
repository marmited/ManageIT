using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ManageIt.Infrastructure.Models.DTO;

namespace ManageIt.Infrastructure.Services.Interfaces
{
    public interface IUserService
    {
        Task<UserDto> GetByEmailAsync(string email);
        Task<UserDto> RegisterAsync(string email, string firstName, string lastName, string password);
        Task<UserDto> AuthenticateAsync(string email, string password);
    }
}
