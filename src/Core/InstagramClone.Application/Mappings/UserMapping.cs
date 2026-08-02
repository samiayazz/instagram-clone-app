using AutoMapper;
using InstagramClone.Application.DTOs.Identity.Requests;
using InstagramClone.Application.DTOs.Identity.Views;
using InstagramClone.Domain.Entities.Identity;

namespace InstagramClone.Application.Mappings
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<AppUser, ViewUserDto>().ReverseMap();
            CreateMap<AppUser, GetUserDto>().ReverseMap();
            CreateMap<AppUser, WriteUserDto>().ReverseMap();
        }
    }
}