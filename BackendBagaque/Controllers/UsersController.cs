using BackendBagaque.Date;
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

        [HttpGet("{IdUser}")]
        public IActionResult GetOne(int IdUser)
        {
            var user = usersService.GetOne(IdUser);
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

        [HttpPut("{userId}")]
        public IActionResult Update(int IdUser, Users user)
        {
            try
            {
                usersService.Update(IdUser, user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{IdUser}")]
        public IActionResult Delete(int IdUser)
        {
            try
            {
                usersService.Delete(IdUser);
                return Ok(IdUser);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
