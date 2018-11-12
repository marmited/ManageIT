using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using ManageIt.Core.Context;
using ManageIt.Core.Repositories.UnitOfWork;
using ManageIt.Infrastructure.Models.DTO;
using ManageIt.Infrastructure.Services.Interfaces;
using ManageIt.Repositories;

namespace ManageIt.Infrastructure.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IEncrypter _encrypter;
        private readonly IMapper _mapper;

        public UserService(IUnitOfWork unitOfWork, IEncrypter encrypter,  IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _encrypter = encrypter;
            _mapper = mapper;
        }

        public async Task<UserDto> GetByEmailAsync(string email)
        {
            var user = await _unitOfWork.Users.GetByEmailAsync(email);
            if(user == null)
                throw new Exception($"User with email: {email} does not exist.");

            return _mapper.Map<User, UserDto>(user);
        }

        public async Task<UserDto> RegisterAsync(string email, string firstName, string lastName, string password)
        {
            var user = await _unitOfWork.Users.GetByEmailAsync(email);
            if(user != null)
                throw new Exception($"User with email: {email} already exists.");

            string passwordSalt = _encrypter.GetSalt(password);

            user = new User()
            {
                Email = email,
                FirstName = firstName,
                LastName = lastName,
                Salt = passwordSalt,
                PasswordHash = _encrypter.GetHash(password, passwordSalt),
                CreateDate = DateTime.Now,
            };

            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CompleteAsync();

            return _mapper.Map<User, UserDto>(user);
        }

    }
}
