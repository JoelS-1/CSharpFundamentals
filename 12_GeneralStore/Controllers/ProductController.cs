using _12_GeneralStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace _12_GeneralStore.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        [HttpPost]
        public async Task<IHttpActionResult> Post(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                await _context.SaveChangesAsync();
                return Ok(); //200 ok status
            }
            return BadRequest(ModelState); //400 bad request
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Product> products = await _context.Products.ToListAsync();
            return Ok(products); //200 ok heres your list
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById([FromUri]int id)
        {
            Product product = await _context.Products.FindAsync(id);
            if(product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPut]
        public async Task<IHttpActionResult> UpdateProduct([FromUri] int id, [FromBody] Product newProduct)
        {
            if (ModelState.IsValid)
            {
                Product oldProduct = await _context.Products.FindAsync(id);

                if(oldProduct != null)
                {
                    oldProduct.Name = newProduct.Name;
                    oldProduct.Quantity = newProduct.Quantity;
                    oldProduct.Price = newProduct.Price;
                    oldProduct.UPC = newProduct.UPC;
                    await _context.SaveChangesAsync();
                    return Ok();
                }
                return NotFound();
            }
            return BadRequest(ModelState);
        }

        [HttpDelete]
        public async Task<IHttpActionResult> Delete([FromUri] int id)
        {
            Product product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
