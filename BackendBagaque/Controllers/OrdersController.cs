using BackendBagaque.Models;
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

        [HttpGet("{idOrders}")]
        public IActionResult GetOne(int id)
        {
            return Ok("GetOne");
        }

        [HttpPost]
        public IActionResult Create([FromBody] Orders orders)
        {
            return Ok("Create" + orders.StatusOrder);
        }
        [HttpPut("{idOrder}")]
        public IActionResult Update(int id, [FromBody] Orders orders)
        {
            return Ok("Update");
        }

        [HttpDelete("{idOrder}")]
        public IActionResult Delete(int id)
        {
            return Ok("Delete");
        }

    }
}