using BackendBagaque.Models;
using BackendBagaque.Services.Orders;
using BackendBagaque.Services.ProducsOrders;
using Microsoft.AspNetCore.Mvc;

namespace BackendBagaque.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : Controller
    {
        private readonly OrdersService ordersService;
        private readonly ProductsOrdersService productsOrdersService;

        public OrdersController(OrdersService ordersService, ProductsOrdersService productsOrdersService)
        {
            this.ordersService = ordersService;
            this.productsOrdersService = productsOrdersService;
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

        [HttpPost("by/{IdUsers}")]
        public IActionResult CreateOrdersBy(Orders order, int idUsers)
        {
            try
            {
                ordersService.CreateOrdersBy(order, idUsers);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("admincreateorders/{IdUsers}")]
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

        [HttpPut("{IdOrders}/updateorder/{IdUsers}")]
        public IActionResult UpdateOrdersBy(int IdOrders, Orders order, int IdUsers)
        {
            try
            {
                ordersService.UpdateOrdersBy(IdOrders, order, IdUsers);
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{IdOrders}/updateorderadmin/{IdUsers}")]
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

        [HttpDelete("{IdOrders}/deleteordersadmin/{IdUsers}")]
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

        //          CONTROLLER PRODUCTSORDERS
        //productOrders
        [HttpGet("productsorders")]
        public IActionResult GetProductsOrdersAll()
        {
            return Ok(productsOrdersService.GetProductsOrdersAll());
        }

        [HttpGet("productsorders/{IdProductsOrders}")]
        public IActionResult GetOneProductsOrders(int IdProductsOrders)
        {
            var productsorders = productsOrdersService.GetOneProductsOrders(IdProductsOrders);
            if (productsorders == null)
            {
                return NotFound();
            }
            return Ok(productsorders);
        }

        [HttpPost("createproductsorders")]
        public IActionResult CreateProductsOrdersBy(ProductsOrders productsorders)
        {
            try
            {
                return Ok(productsOrdersService.CreateProductsOrdersBy(productsorders));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("updateproductsorders/{IdProductsOrders}")]
        public IActionResult UpdateProductOrdersBy(ProductsOrders productsorders, int IdProductsOrders)
        {
            try
            {
                productsOrdersService.UpdateProductOrdersBy(productsorders, IdProductsOrders);
                return Ok(productsorders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("deleteproductorders/{IdProductsOrders}")]
        public IActionResult DeleteProductOrderBy(int IdProductsOrders)
        {
            try
            {
                productsOrdersService.DeleteProductOrderBy(IdProductsOrders);
                return Ok("Pedido Excluido com Sucesso " + IdProductsOrders);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}