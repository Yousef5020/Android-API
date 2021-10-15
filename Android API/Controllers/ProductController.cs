using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Android_API.Interfaces;
using Android_API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Android_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;

        public ProductController(IProduct product)
        {
            _product = product;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _product.GetProducts();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id:int}")]
        public Product Get(int id)
        {
            return _product.GetProduct(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public Product Post([FromBody] Product product)
        {
            return _product.AddProduct(product);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id:int}")]
        public Product Put(int id, [FromBody] Product product)
        {
            return _product.EditProduct(id ,product);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
