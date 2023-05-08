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

        /*                 CONTROLLE ORDERS            */
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

        [HttpPost("{IdUsers}")]
        public IActionResult CreateOrdersByAdmin(Orders order, int idUsers)
        {
            try
            {
                ordersService.CreateOrdersByAdm(order, idUsers);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("by/{IdOrders}")]
        public IActionResult UpdateOrdersBy(int IdOrders, Orders order)
        {
            try
            {
                ordersService.UpdateOrdersBy(IdOrders, order);
                return Ok(order.TypePayment);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{IdOrders}/admin/{IdUsers}")]
        public IActionResult UpdateOrdersByAdmin(int IdOrders, Orders order, int IdUsers)
        {
            try
            {
                ordersService.UpdateOrdersByAdmin(IdOrders, order, IdUsers);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{IdOrders}/admin/{IdUsers}")]
        public IActionResult DeleteOrderByAdm(int IdOrders, int IdUsers)
        {
            try
            {
                ordersService.DeleteOrderByAdm(IdOrders, IdUsers);
                return Ok("Pedido Excluido com Sucesso " + IdOrders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        /*          CONTROLLER ORDERS/PRODUCTORDER                     */

        [HttpGet("productorder")]
        public IActionResult GetProductOrderAll()
        {
            return Ok(ordersService.GetProductOrderAll());
        }

        [HttpGet("productorder/{IdProductOrder}")]
        public IActionResult GetOneProductOrder(int IdProductOrder)
        {
            var productorder = ordersService.GetOneProductOrder(IdProductOrder);
            if (productorder == null)
            {
                return NotFound();
            }
            return Ok(productorder);
        }

        [HttpPost("createproductorder")]
        public IActionResult CreateProductOrdersBy(ProductOrder productorder)
        {
            try
            {
                ordersService.CreateProductOrdersBy(productorder);
                return Ok(productorder);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}