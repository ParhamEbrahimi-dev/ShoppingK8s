using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;
using Shopping.API.Data;
using Shopping.API.Models;

namespace Shopping.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        private readonly ILogger<ProductController> _logger;
        private readonly ProductContext _context;
        public ProductController(ProductContext context, ILogger<ProductController> logger)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet("/products")]
        public async Task<IEnumerable<Product>> Get()
        {

            return await _context.Products.Find(p => true).ToListAsync();
        }


    }
}
