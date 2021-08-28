using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;
using Infrastructure.Data.Persistence;
using MediatR;

namespace Application.Application.GuildMember.Commands
{
    public class CreateGuildMemberCommand : IRequest<Domain.Models.GuildMember>
    {
        public string GuildMemberId { get; set; }
        public string UserId { get; set; }
        public string GuildId { get; set; }
        public string Nickname { get; set; }
        public DateTime JoinedAt { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsBanned { get; set; }
        public bool IsKicked { get; set; }
    }

    public class Handler : IRequestHandler<CreateGuildMemberCommand, Domain.Models.GuildMember>
    {
        private readonly IGuildMemberRepository _repository;
        private readonly IMapper _mapper;

        public Handler(ApplicationDbContext context, IMapper mapper, IGuildMemberRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Domain.Models.GuildMember> Handle(CreateGuildMemberCommand request, CancellationToken cancellationToken)
        {
            var guildMember = _mapper.Map<Domain.Models.GuildMember>(request);
            return await _repository.CreateGuildMemberAsync(guildMember);
        }
    }
}