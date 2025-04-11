using MediatR;
using Onion.Application.Features.Mediator.Results;

namespace Onion.Application.Features.Mediator.Queries
{
    public record GetProductByIdQuery(Guid id) : IRequest<GetProductByIdQueryResult>;
}
