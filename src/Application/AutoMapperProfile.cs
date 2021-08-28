using Application.Application.Guild.Commands;
using Application.Application.User.Commands;
using Application.Dtos.Guild.Get;
using Application.Dtos.User.Get;
using AutoMapper;
using Domain.Models;

namespace Application
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Guild, GetGuildDto>();
            CreateMap<CreateGuildCommand, Guild>();

            CreateMap<User, GetUserDto>();
            CreateMap<CreateUserCommand, User>();
        }
    }
}