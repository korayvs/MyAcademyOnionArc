using MediatR;

namespace Onion.Application.Features.Mediator.Commands
{
    public record CreateProductCommand : IRequest<bool>
    {
        public string ProductName { get; init; }
        public decimal Price { get; init; }
        public int Stock { get; init; }
        public Guid CategoryId { get; init; }
    }
}
