using Microsoft.AspNetCore.Mvc;
using Wikipi.Domain.Domain.Contracts;
using Wikipi.Domain.Models;
using Wikipi.Domain.Repository.Interfaces;

namespace Wikipi.Domain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsHandler _productHandler;
        public ProductsController(IProductsHandler productHandler)
        {
           _productHandler = productHandler;
        }
        [HttpGet("get-product")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<Product> GetProduct(int productId)
        {
            return await Task.FromResult(new Product());
        }

        [HttpPost]
        public async Task<Product> CreateProduct(Product p)
        {
            return await _productHandler.Create(p);
        }
    }
}
