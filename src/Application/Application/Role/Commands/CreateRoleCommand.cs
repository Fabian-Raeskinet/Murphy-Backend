using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;
using Infrastructure.Data.Persistence;
using MediatR;

namespace Application.Application.Role.Commands
{
    public class CreateRoleCommand: IRequest<Domain.Models.Role>
    {
        public string RoleId { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Position { get; set; }
        public int MemberRoleCount { get; set; }
        public string GuildId { get; set; }
    }

    public class Handler : IRequestHandler<CreateRoleCommand, Domain.Models.Role>
    {
        private readonly IRoleRepository _repository;
        private readonly IMapper _mapper;

        public Handler(ApplicationDbContext context, IMapper mapper, IRoleRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Domain.Models.Role> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = _mapper.Map<Domain.Models.Role>(request);
            return await _repository.CreateRoleAsync(role);
        }
    }
}