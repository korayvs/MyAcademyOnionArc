namespace Onion.Application.Features.CQRS.Results
{
    public record GetCategoryQueryResult(Guid CategoryId, string CategoryName);
}
