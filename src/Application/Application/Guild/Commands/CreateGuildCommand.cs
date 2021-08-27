using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.Guild.Commands
{
    public class CreateGuildCommand : IRequest<Domain.Models.Guild>
    {
        public string GuildId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Banner { set; get; }
        public string Description { get; set; }
        public string OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAvailable { get; set; }
        public string AfkChannelId { get; set; }
        public int MemberCount { get; set; }
    }

    public class Handler : IRequestHandler<CreateGuildCommand, Domain.Models.Guild>
    {
        private readonly IGuildRepository _repository;
        private readonly IMapper _mapper;

        public Handler(IGuildRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Domain.Models.Guild> Handle(CreateGuildCommand request, CancellationToken cancellationToken)
        {
            var guild = _mapper.Map<Domain.Models.Guild>(request);
            return await _repository.CreateGuildAsync(guild);
        }
    }
}