using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace DemoFinal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly ProductService _productService;
        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{name}")]
        public IActionResult GetByName(string name, int value)
        {
            return Ok(_productService.Get(name, value));
        }

        
    }
}
