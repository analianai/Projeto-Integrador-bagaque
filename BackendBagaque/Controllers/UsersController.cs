using BackendBagaque.Data;
using BackendBagaque.Models;
using BackendBagaque.Services.Users;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BackendBagaque.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly UsersService usersService;
        public UsersController(UsersService usersService)
        {
            this.usersService = usersService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(usersService.GetAll());
        }

        [HttpGet("{IdUsers}")]
        public IActionResult GetOne(int IdUsers)
        {
            var user = usersService.GetOne(IdUsers);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Create(Users user)
        {
            try
            {
                usersService.Create(user);
                return Ok(user);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{IdUsers}")]
        public IActionResult Update(int IdUsers, Users user)
        {
            try
            {
                usersService.Update(IdUsers, user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{IdUsers}")]
        public IActionResult Delete(int IdUsers)
        {
            try
            {
                usersService.Delete(IdUsers);
                return Ok("Usuario deletado com sucesso "+IdUsers);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
