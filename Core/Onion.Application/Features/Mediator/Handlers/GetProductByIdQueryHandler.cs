using AutoMapper;
using MediatR;
using Onion.Application.Features.Mediator.Queries;
using Onion.Application.Features.Mediator.Results;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Features.Mediator.Handlers
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductByIdQueryResult>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<GetProductByIdQueryResult> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.id);
            return _mapper.Map<GetProductByIdQueryResult>(product);
        }
    }
}
