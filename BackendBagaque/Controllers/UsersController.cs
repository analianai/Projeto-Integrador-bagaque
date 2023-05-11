﻿using BackendBagaque.Data;
using BackendBagaque.Models;
using BackendBagaque.Services.Products;
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

        [HttpGet("admin/{IdUsers}")]
        public IActionResult GetAllAdmin(int IdUsers)
        {
            try
            {
                return Ok(usersService.GetAllAdmin(IdUsers));
            } 
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }            
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

        [HttpPost("admin/{IdUsers}")]
        public IActionResult CreateByUserAdmin(Users users, int IdUsers)
        {
            try
            {
                usersService.CreateByUserAdmin(users, IdUsers);
                return Ok(users);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateByUser(Users users)
        {
            try
            {
                usersService.CreateByUser(users);
                return Ok(users);
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
