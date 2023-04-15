<<<<<<< HEAD
﻿using BackendBagaque.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BackendBagaque.Controllers
{
    [Route("[controller]")]
    public class OrdersController : Controller
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
        public IActionResult Create([FromBody] Orders orders)
        {
            return Ok("Create" + orders.IdOrder);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Orders orders)
        {
            return Ok("Update");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Delete");
        }

    }
=======
﻿using BackendBagaque.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BackendBagaque.Controllers
{
    [Route("[controller]")]
    public class OrdersController : Controller
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
        public IActionResult Create([FromBody] Orders orders)
        {
            return Ok("Create" + orders.IdOrder);
        }
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Orders orders)
        {
            return Ok("Update");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok("Delete");
        }

    }
>>>>>>> main
}