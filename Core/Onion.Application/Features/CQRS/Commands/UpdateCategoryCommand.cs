namespace Onion.Application.Features.CQRS.Commands
{
    public record UpdateCategoryCommand(Guid CategoryId, string CategoryName);
}
