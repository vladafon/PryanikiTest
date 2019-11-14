using System;
using Microsoft.AspNetCore.Mvc;
using PryanikiTest.Models;

namespace PryanikiTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // POST api/values
        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
            int productId = order.Product.ProductId;
            foreach (var product in DB.DB.Products)
            {
                if (product.ProductId == productId)
                {
                    if (order.Quantity > product.Quantity)
                        return StatusCode(409, new Result {Status = "Where are not such many products"});
                    product.Quantity -= order.Quantity;
                    order.Product = product;
                    order.OrderDateTime = DateTime.Now;
                    order.OrderId = DB.DB.GetOrderId();

                    DB.DB.Orders.Add(order);
                    break;
                }
                    
            }

            return Ok(new Result {Status = "Order was added"});
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            foreach (var order in DB.DB.Orders)
            {
                if (order.OrderId == id)
                {
                    int productId = order.Product.ProductId;
                    DB.DB.Orders.Remove(order);
                    foreach (var product in DB.DB.Products)
                    {
                        if (product.ProductId == productId)
                            product.Quantity += order.Quantity;

                    }
                    return Ok(new Result { Status = "Order was deleted"});
                }
            }
            return StatusCode(404, new Result { Status = "Order wasn't found"});
        }
    }
}