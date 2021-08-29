using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Dtos.Role.Get;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.Role.Queries
{
    public class GetAllRolesQuery: IRequest<List<GetRoleDto>>
    {
        
    }

    public class Handler : IRequestHandler<GetAllRolesQuery, List<GetRoleDto>>
    {
        private readonly IRoleRepository _repository;
        private readonly IMapper _mapper;

        public Handler(IRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetRoleDto>> Handle(GetAllRolesQuery request, CancellationToken cancellationToken)
        {
            var guildMembers = await _repository.GetRolesAsync();
            return guildMembers.Select(g => _mapper.Map<GetRoleDto>(g)).ToList();
        }
    }
}