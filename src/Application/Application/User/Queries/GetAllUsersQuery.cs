using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Application.Application.Guild.Queries;
using Application.Dtos.Guild.Get;
using Application.Dtos.User.Get;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.User.Queries
{
    public class GetAllUsersQuery: IRequest<List<GetUserDto>>
    {
        
    }

    public class Handler : IRequestHandler<GetAllUsersQuery, List<GetUserDto>>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public Handler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetUserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _repository.GetUsersAsync();
            return users.Select(u => _mapper.Map<GetUserDto>(u)).ToList();
        }
    }
}