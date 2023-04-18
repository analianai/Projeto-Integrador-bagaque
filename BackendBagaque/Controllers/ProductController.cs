using BackendBagaque.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendBagaque.Controllers
{
    [Route("[controller]")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return Ok("GetAll");
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok("GetOne");
        }

        [HttpPost]
        public IActionResult Create([FromBody] Product product)
        {
            return Ok("Create" + product.Title);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Product orders)
        {
            return Ok("Update");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Delete");
        }
    }
}
