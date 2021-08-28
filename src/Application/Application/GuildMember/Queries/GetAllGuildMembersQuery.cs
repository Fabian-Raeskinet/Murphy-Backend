using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Dtos.GuildMember.Get;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.GuildMember.Queries
{
    public class GetAllGuildMembersQuery : IRequest<List<GetGuildMemberDto>>
    {
        
    }

    public class Handler : IRequestHandler<GetAllGuildMembersQuery, List<GetGuildMemberDto>>
    {
        private readonly IGuildMemberRepository _repository;
        private readonly IMapper _mapper;

        public Handler(IGuildMemberRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetGuildMemberDto>> Handle(GetAllGuildMembersQuery request, CancellationToken cancellationToken)
        {
            var guildMembers = await _repository.GetGuildMembersAsync();
            return guildMembers.Select(g => _mapper.Map<GetGuildMemberDto>(g)).ToList();
        }
    }
}