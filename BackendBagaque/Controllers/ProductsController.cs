
using BackendBagaque.Services.Products;
using BackendBagaque.Models;
using Microsoft.AspNetCore.Mvc;


namespace Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly ProductsService productsService;

        public ProductsController(ProductsService productsService)
        {
            this.productsService = productsService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(productsService.GetAll());
        }

        [HttpGet("{IdProducts}")]
        public IActionResult GetOne(int IdProducts)
        {
            var products = productsService.GetOne(IdProducts) ;
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPost("{IdUsers}")]
        public IActionResult CreateProductByAdm(Products product, int IdUsers)
        {
            try
            {
                productsService.CreateProductByAdm(product, IdUsers);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

     
        [HttpPut("{IdProducts}/admin/{IdUsers}")]
        public IActionResult UpdateProductByAdmin(int IdProducts, Products product, int IdUsers)
        {
            try
            {
                productsService.UpdateProductByAdmin(IdProducts, product, IdUsers);
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{IdProducts}/admin/{IdUsers}")]
        public IActionResult DeleteProductByAdmin(int IdProducts, int IdUsers)
        {
            try
            {
                productsService.DeleteProductByAdmin(IdProducts, IdUsers);
                return Ok(IdProducts);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
