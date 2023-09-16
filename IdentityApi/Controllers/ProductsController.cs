using IdentityApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "PS5",
                    Price=500
                },
                new Product
                {
                    Id=2,
                    Name="Xbox Series S",
                    Price = 200
                },
                new Product
                {
                    Id = 3,
                    Name = "IPhone 15",
                    Price = 800
                }
            };
            return Ok(products);
        }
    }
}
