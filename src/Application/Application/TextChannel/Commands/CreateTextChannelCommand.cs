using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.TextChannel.Commands
{
    public class CreateTextChannelCommand : IRequest<Domain.Models.TextChannel>
    {
        public string TextChannelId { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public bool IsNsfw { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CategoryChannelId { get; set; }
        public string GuildId { get; set; }
    }

    public class Handler : IRequestHandler<CreateTextChannelCommand, Domain.Models.TextChannel>
    {
        private readonly ITextChannelRepository _repository;
        private readonly IMapper _mapper;

        public Handler(ITextChannelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Domain.Models.TextChannel> Handle(CreateTextChannelCommand request, CancellationToken cancellationToken)
        {
            var textChannel = _mapper.Map<Domain.Models.TextChannel>(request);
            return await _repository.CreateTextChannelAsync(textChannel);
        }
    }
}