using BackendBagaque.Models;
using BackendBagaque.Services.Orders;
using Microsoft.AspNetCore.Mvc;

namespace BackendBagaque.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : Controller
    {
        private readonly OrdersService ordersService;

        public OrdersController(OrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(ordersService.GetAll());
        }

        [HttpGet("{IdOrders}")]
        public IActionResult GetOne(int IdOrders)
        {
            var order = ordersService.GetOne(IdOrders);
            if (order == null)
            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost]
        public IActionResult Create(Orders order)
        {
            try
            {
                ordersService.Create(order);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{IdOrders}")]
        public IActionResult Update(int IdOrders, Orders order)
        {
            try
            {
                ordersService.Update(IdOrders, order);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{IdOrders}")]
        public IActionResult Delete(int IdOrders)
        {
            try
            {
                ordersService.Delete(IdOrders);
                return Ok(IdOrders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}