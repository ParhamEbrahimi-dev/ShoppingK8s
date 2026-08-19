using Microsoft.AspNetCore.Mvc;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ILogger<ProductController> logger;

        public ProductController(ILogger<ProductController> _logger)
        {
            logger = _logger;
        }

        [HttpGet("/products")]
        public IEnumerable<Product> Get() 
        {

            return ProductContext.Products;
        }


    }
}
