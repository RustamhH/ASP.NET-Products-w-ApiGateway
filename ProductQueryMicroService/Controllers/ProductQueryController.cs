using Database.Entities.Concretes;
using Database.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.AccessControl;

namespace ProductQueryMicroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductQueryController : ControllerBase
    {
        

        private readonly ILogger<ProductQueryController> _logger;
        private readonly IProductQueryRepository _productqueryrepos;
        

        public ProductQueryController(ILogger<ProductQueryController> logger,IProductQueryRepository productQueryRepository)
        {
            _logger = logger;
            _productqueryrepos = productQueryRepository;
        }

        [HttpGet("GetAllProduct")]
        public IActionResult GetAllProduct()
        {
            return Ok(_productqueryrepos.GetAllProductsAsync());
        }

        [HttpGet("GetProductById/{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productqueryrepos.GetProductById(id);
            return product is not null ? Ok(product) : NotFound("Product Not Found");
        }
    }
}
