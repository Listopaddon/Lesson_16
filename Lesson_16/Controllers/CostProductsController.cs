using Lesson_16.Models.Domain;
using Lesson_16.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace Lesson_16.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CostProductsController : Controller
    {
        ActionWithProducts action;
        public CostProductsController(ActionWithProducts action)
        {
            this.action = action;
        }

        [HttpGet]
        public IActionResult SummAllProduct()
        {
            return Ok(action.SummAllProducts());
        }

        [HttpGet]
        public IActionResult SummProductType(TypeProducts type)
        {
            return Ok(action.SummProductsOnType(type));
        }
    }
}
