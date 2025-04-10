namespace Onion.Application.Features.CQRS.Results
{
    public record GetCategoryByIdQueryResult(Guid CategoryId, string CategoryName);
}
