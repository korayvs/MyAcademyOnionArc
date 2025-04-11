using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Onion.Application.Features.Mediator.Commands;
using Onion.Application.Features.Mediator.Queries;

namespace Onion.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _mediator.Send(new GetProductQuery());
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommand command)
        {
            var result = await _mediator.Send(command);
            if(result == false)
            {
                return BadRequest("Ürün eklerken bir hata oluştu.");
            }
            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            if(product == null)
            {
                return NotFound("Ürün bulunamadı.");
            }
            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductCommand command)
        {
            var result = await _mediator.Send(command);
            if(result == false)
            {
                return BadRequest("Ürün güncellerken bir hata oluştu.");
            }
            return Ok("Ürün başarıyla güncellendi.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var product = await _mediator.Send(new GetProductByIdQuery(id));
            if (product == null)
            {
                return NotFound("Ürün bulunamadı.");
            }
            var result = await _mediator.Send(new RemoveProductCommand(id));
            if (result == false)
            {
                return BadRequest("Ürün silinirken bir hata oldu.");
            }
            return Ok("Ürün başarıyla silindi.");
        }
    }
}
