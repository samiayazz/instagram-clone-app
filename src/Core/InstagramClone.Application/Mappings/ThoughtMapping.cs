using AutoMapper;
using InstagramClone.Application.DTOs.Thought.Requests;
using InstagramClone.Application.DTOs.Thought.Views;
using InstagramClone.Domain.Entities;

namespace InstagramClone.Application.Mappings
{
    public class ThoughtMapping : Profile
    {
        public ThoughtMapping()
        {
            CreateMap<Thought, ViewThoughtDto>().ReverseMap();
            CreateMap<Thought, WriteThoughtDto>().ReverseMap();
        }
    }
}