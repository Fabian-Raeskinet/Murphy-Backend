using System.Threading;
using System.Threading.Tasks;
using Domain.Interfaces;
using MediatR;

namespace Application.Application.Seed.Commands
{
    public class DeleteDataCommand : IRequest<bool>
    {
        
    }

    public class Handler : IRequestHandler<DeleteDataCommand, bool>
    {
        private readonly ISeedRepository _repository;

        public Handler(ISeedRepository repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(DeleteDataCommand request, CancellationToken cancellationToken)
        {
            return await _repository.ResetDataAsync();
        }
    }
}