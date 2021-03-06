using Application.Application.CategoryChannel.Commands;
using Application.Application.Guild.Commands;
using Application.Application.GuildMember.Commands;
using Application.Application.Role.Commands;
using Application.Application.TextChannel.Commands;
using Application.Application.User.Commands;
using Application.Dtos.CategoryChannel.Get;
using Application.Dtos.Guild.Get;
using Application.Dtos.GuildMember.Get;
using Application.Dtos.Role.Get;
using Application.Dtos.TextChannel.Get;
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

            CreateMap<GuildMember, GetGuildMemberDto>();
            CreateMap<CreateGuildMemberCommand, GuildMember>();

            CreateMap<Role, GetRoleDto>();
            CreateMap<CreateRoleCommand, Role>();

            CreateMap<CategoryChannel, GetCategoryChannelDto>();
            CreateMap<CreateCategoryChannelCommand, CategoryChannel>();

            CreateMap<TextChannel, GetTextChannelDto>();
            CreateMap<CreateTextChannelCommand, TextChannel>();
        }
    }
}