using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Dtos.Guild.Get;
using AutoMapper;
using Domain.Interfaces;
using Infrastructure.Data.Persistence;
using MediatR;

namespace Application.Application.Guild.Queries
{
    public class GetAllGuildsQuery : IRequest<List<GetGuildDto>>
    {
        
    }

    public class Handler : IRequestHandler<GetAllGuildsQuery, List<GetGuildDto>>
    {
        private readonly IGuildRepository _repository;
        private readonly IMapper _mapper;

        public Handler(IGuildRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetGuildDto>> Handle(GetAllGuildsQuery request, CancellationToken cancellationToken)
        {
            var guilds = await _repository.GetGuildsAsync();
            return guilds.Select(g => _mapper.Map<GetGuildDto>(g)).ToList();
        }
    }
}