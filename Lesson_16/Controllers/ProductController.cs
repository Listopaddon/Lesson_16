using Lesson_16.Models.Domain;
using Lesson_16.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace Lesson_16.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductController : Controller
    {
        ActionWithProducts action;
        public ProductController(ActionWithProducts action)
        {
            this.action = action;
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            action.AddProduct(product);
            return Created($"Name {product.Name}", product);
        }

        [HttpPut]
        public IActionResult ReplaceProduct(int idProduct, Product product)
        {
            action.ReplaceProduct(idProduct, product);
            return Created($"Replace {product.Name}", product);
        }

        [HttpGet]
        public IActionResult GetAllProduct()
        {
            return Ok(action.GetAllProducts());
        }
    }
}
