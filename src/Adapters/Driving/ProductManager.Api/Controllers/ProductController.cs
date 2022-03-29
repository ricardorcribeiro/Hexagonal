using Microsoft.AspNetCore.Mvc;
using ProductManager.Domain.Dtos;
using ProductManager.Domain.Services;

namespace ProductManager.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
        => (_productService) = (productService);

    [HttpGet]
    public ProductDto Get(int id) => _productService.GetById(id);

    [HttpPost]
    public void Post([FromBody] ProductDto product)
        => _productService.Add(product);

    [HttpPut]
    public void Put([FromBody] ProductDto product)
        => _productService.Update(product);
}
