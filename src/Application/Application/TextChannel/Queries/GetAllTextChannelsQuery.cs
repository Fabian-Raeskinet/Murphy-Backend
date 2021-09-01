using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Dtos.TextChannel.Get;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.TextChannel.Queries
{
    public class GetAllTextChannelsQuery : IRequest<List<GetTextChannelDto>>
    {
        
    }

    public class Handler : IRequestHandler<GetAllTextChannelsQuery, List<GetTextChannelDto>>
    {
        private readonly ITextChannelRepository _repository;
        private readonly IMapper _mapper;

        public Handler(ITextChannelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetTextChannelDto>> Handle(GetAllTextChannelsQuery request, CancellationToken cancellationToken)
        {
            var textChannels = await _repository.GetTextChannelsAsync();
            return textChannels.Select(t => _mapper.Map<GetTextChannelDto>(t)).ToList();
        }
    }
}