using AutoMapper;
using InstagramClone.Application.DTOs.Group.Requests;
using InstagramClone.Application.DTOs.Group.Views;
using InstagramClone.Domain.Entities;

namespace InstagramClone.Application.Mappings
{
    public class GroupMapping : Profile
    {
        public GroupMapping()
        {
            CreateMap<Group, ViewGroupDto>().ReverseMap();
            CreateMap<Group, WriteGroupDto>().ReverseMap();
        }
    }
}