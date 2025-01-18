using AutoMapper;
using imrp.application.Dto;
using imrp.domain.Entities;

namespace imrp.persistence.Mappers;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<User, UserDto>().ReverseMap();
    }
}