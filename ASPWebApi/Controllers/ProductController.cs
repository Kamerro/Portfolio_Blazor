using ClassWithParameters;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("getProducts")]
        public IActionResult GetAllProducts()
        {
            List<Products> list = new List<Products>()
            {
                new Products(){Id = 0,Name = "Toothpast",Price = 10,Description = "Casual toothpast"},
                new Products(){Id = 1,Name = "Bike",Price = 300,Description = "Bike like seen"},
                new Products(){Id = 2,Name = "Juice",Price = 2,Description = "Unsee juice"},
                new Products(){Id = 3,Name = "Book intro to BDSM",Price = 35,Description = "For all lovers"},
                new Products(){Id = 4,Name = "Bondage",Price = 25,Description = "Spicy aroma in bedroom"},
                new Products(){Id = 5,Name = "Acer Helios 300",Price = 2000,Description = "Best laptop ever"},
                new Products(){Id = 6,Name = "Spoon",Price = 0.5m,Description = "Rusty with holes, but at least not cheap!"},
                new Products(){Id = 7,Name = "Tea pot",Price = 1,Description = "With cat image, purrfect!"},
                new Products(){Id = 8,Name = "Arabica",Price = 12,Description = "Damn thats good dip with nachos"},
            };

            return Ok(list);
        }
    }
}
