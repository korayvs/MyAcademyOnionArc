using AutoMapper;
using Onion.Application.Features.CQRS.Results;
using Onion.Application.Interfaces;
using Onion.Domain.Entities;

namespace Onion.Application.Features.CQRS.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly IRepository<Category> _repository;
        private readonly IMapper _mapper;

        public GetCategoryQueryHandler(IRepository<Category> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<GetCategoryQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();

            return _mapper.Map<List<GetCategoryQueryResult>>(values);
        }
    }
}
