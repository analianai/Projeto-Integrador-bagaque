using BackendBagaque.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendBagaque.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
       
        public IActionResult Index()
        {
            return Ok("GetAll");
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int idUser)
        {
            return Ok("GetOne");
        }

        [HttpPost]
        public IActionResult Create([FromBody] Users users)
        {
            return Ok("Create" + users.Names);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int idUser, [FromBody] Users users)
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
