using BackendBagaque.Models;
using BackendBagaque.Services.ProducsOrders;
using Microsoft.AspNetCore.Mvc;

namespace BackendBagaque.Controllers
{ /*
    [ApiController]
    [Route("[controller]")]
    public class ProductsOrdersController : Controller
    {
       
        private readonly ProductsOrdersService productsordersService;

        public ProductsOrdersController (ProductsOrdersService productsordersService)
        {
            this.productsordersService = productsordersService;
        }
        
        [HttpGet]
        public IActionResult GetProductsOrdersAll()
        {
            return Ok(productsordersService.GetProductsOrdersAll());
        }

        [HttpGet("{IdProductsOrders}")]
        public IActionResult GetOneProductsOrders(int IdProductsOrders)
        {
            var productsorders = productsordersService.GetOneProductsOrders(IdProductsOrders);
            if (productsorders == null)
            {
                return NotFound();
            }
            return Ok(productsorders);
        }

        [HttpPost]
        public IActionResult CreateBy(ProductsOrders productsorders)
        {
            try
            {
                return Ok(productsordersService.CreateBy(productsorders));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
        */

}
