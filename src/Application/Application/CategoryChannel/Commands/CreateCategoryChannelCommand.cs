using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.CategoryChannel.Commands
{
    public class CreateCategoryChannelCommand : IRequest<Domain.Models.CategoryChannel>
    {
        public string CategoryChannelId { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public DateTime CreatedAt { get; set; }
        public string GuildId { get; set; }
    }

    public class Handler : IRequestHandler<CreateCategoryChannelCommand, Domain.Models.CategoryChannel>
    {
        private readonly ICategoryChannelRepository _repository;
        private readonly IMapper _mapper;

        public Handler(ICategoryChannelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Domain.Models.CategoryChannel> Handle(CreateCategoryChannelCommand request, CancellationToken cancellationToken)
        {
            var guild = _mapper.Map<Domain.Models.CategoryChannel>(request);
            return await _repository.CreateCategoryChannelAsync(guild);
        }
    }
}