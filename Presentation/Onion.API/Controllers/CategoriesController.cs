using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.Features.CQRS.Handlers;

namespace Onion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesControlle : ControllerBase
    {
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;

        public CategoriesControlle(GetCategoryQueryHandler getCategoryQueryHandler)
        {
            _getCategoryQueryHandler = getCategoryQueryHandler;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return Ok(values);
        }
    }
}
