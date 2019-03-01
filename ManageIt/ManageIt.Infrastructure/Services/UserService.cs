using System;
using System.Threading.Tasks;
using AutoMapper;
using ManageIt.Core.Context;
using ManageIt.Core.Repositories.UnitOfWork;
using ManageIt.Infrastructure.Models.DTO;
using ManageIt.Infrastructure.Services.Interfaces;

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

        public async Task<UserDto> AuthenticateAsync(string email, string password)
        {
            User user = await _unitOfWork.Users.GetByEmailAsync(email);
            if (user != null)
            {
                string hash = _encrypter.GetHash(password, user.Salt);

                if (user.PasswordHash == hash)
                {
                    return _mapper.Map<User, UserDto>(user);
                }
            }
            return null;
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

            string passwordSalt = _encrypter.GetSalt();

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
