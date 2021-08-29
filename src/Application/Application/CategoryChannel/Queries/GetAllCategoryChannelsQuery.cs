using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Dtos.CategoryChannel.Get;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.CategoryChannel.Queries
{
    public class GetAllCategoryChannelsQuery: IRequest<List<GetCategoryChannelDto>>
    {
        
    }

    public class Handler : IRequestHandler<GetAllCategoryChannelsQuery, List<GetCategoryChannelDto>>
    {
        private readonly ICategoryChannelRepository _repository;
        private readonly IMapper _mapper;

        public Handler(ICategoryChannelRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCategoryChannelDto>> Handle(GetAllCategoryChannelsQuery request, CancellationToken cancellationToken)
        {
            var categoryChannels = await _repository.GetCategoryChannelsAsync();
            return categoryChannels.Select(g => _mapper.Map<GetCategoryChannelDto>(g)).ToList();
        }
    }
}