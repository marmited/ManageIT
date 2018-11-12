using AutoMapper;
using ManageIt.Core.Context;
using ManageIt.Infrastructure.Models.DTO;

namespace ManageIt.Infrastructure.Mappers
{
    public static class AutoMapperConfig
    {
        public static IMapper Initialize()
            => new MapperConfiguration(x=>
                x.CreateMap<User, UserDto>())
                .CreateMapper();
    }
}
