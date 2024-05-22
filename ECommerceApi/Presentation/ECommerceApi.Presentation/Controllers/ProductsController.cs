using ECommerceApi.Application.Features.Product.Commands.CreateProduct;
using ECommerceApi.Application.Features.Product.Queries.GetAllProduct;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.Presentation.Controllers;

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
        return Ok(await _mediator.Send(new GetAllProductQueryRequest()));
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateProductCommandRequest request)
    {
        try
        {
            return Ok(await _mediator.Send(request));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

}
