using Onion.Application.Features.CQRS.Results;

namespace Onion.Application.Features.Mediator.Results
{
    public record GetProductQueryResult(Guid ProductId, string ProductName, decimal Price, int Stock, Guid CategoryId);
}
