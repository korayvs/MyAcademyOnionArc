namespace Onion.Application.Features.Mediator.Results
{
    public record GetProductByIdQueryResult(Guid ProductId, string ProductName, decimal Price, int Stock, Guid CategoryId);
}
