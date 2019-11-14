using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PryanikiTest.Models;

namespace PryanikiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<ICollection<Product>> Get()
        {
            return DB.DB.Products;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            foreach (var product in DB.DB.Products)
            {
                if (product.ProductId == id)
                    return product;
            }
            return StatusCode(404,new Result{Status = "Product wasn't found"});
        }
    }
}
