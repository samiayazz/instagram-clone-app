using AutoMapper;
using InstagramClone.Application.DTOs.Identity;
using InstagramClone.Application.DTOs.Identity.Requests;
using InstagramClone.Application.DTOs.Identity.Views;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Application.Maps
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<AppUser, ViewUserDto>().ReverseMap();
            CreateMap<AppUser, GetUserDto>().ReverseMap();
            CreateMap<AppUser, WriteUserDto>().ReverseMap();
        }
    }
}