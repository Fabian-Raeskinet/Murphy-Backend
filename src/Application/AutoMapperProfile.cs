using Application.Dtos.Guild.Get;
using AutoMapper;
using Domain.Models;

namespace Application
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Guild, GetGuildDto>();
        }
    }
}