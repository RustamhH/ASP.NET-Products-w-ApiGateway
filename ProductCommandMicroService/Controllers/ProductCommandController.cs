using Database.Entities.Concretes;
using Database.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace ProductCommandMicroService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductCommandController : ControllerBase
    {


        private readonly ILogger<ProductCommandController> _logger;
        private readonly IProductCommandRepository _productcommandrepos;


        public ProductCommandController(ILogger<ProductCommandController> logger, IProductCommandRepository productCommandRepository)
        {
            _logger = logger;
            _productcommandrepos = productCommandRepository;
        }

        [HttpPost("AddProduct")]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productcommandrepos.AddProductAsync(product);
            return Ok("Product Add edildi");
        }
        
        [HttpPost("UpdateProduct")]
        public IActionResult UpdateProduct([FromBody] Product product)
        {
            _productcommandrepos.UpdateProductAsync(product);
            return Ok("Product Update edildi");
        }
        
      
        
        [HttpPost("DeleteProduct")]
        public IActionResult DeleteProduct([FromBody] int productId)
        {
            _productcommandrepos.DeleteProductAsync(productId);
            return Ok("Product Delete edildi");
        }
    }
}
