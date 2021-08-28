using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.User.Commands
{
    public class CreateUserCommand : IRequest<Domain.Models.User>
    {
        public string UserId { get; set; }
        public string Username { get; set; }
        public string Tag { get; set; }
        public string Avatar { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsBot { get; set; }
    }

    public class Handler : IRequestHandler<CreateUserCommand, Domain.Models.User>
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public Handler(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        
        public async Task<Domain.Models.User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<Domain.Models.User>(request);
            return await _repository.CreateUserAsync(user);
        }
    }
}