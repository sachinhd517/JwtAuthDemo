using JwtAuthDemo.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public ProductController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetProduct() 
        {
            var products = _context.Products.ToList();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            else 
            { 
                return Ok(product);
            }
        }

        //[HttpPost]
        //public IActionResult CreateProduct([FromBody] ProductController product)
        //{
        //    _context.Products.Add(product);
        //    _context.SaveChanges();
        //    return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        //}
    }
}
