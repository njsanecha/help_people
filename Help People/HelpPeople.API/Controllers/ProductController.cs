using HelpPeople.Data.Model;
using HelpPeople.Services.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HelpPeople.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController(IProductService productService) : ControllerBase
    {
        /// <summary>
        /// Returns the products list of the database
        /// </summary>
        /// <returns>User list</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Products>>> Get()
        {
            return Ok(await productService.Get());
        }

        /// <summary>
        /// Returns a product by id
        /// </summary>
        /// param name="id">product id</param>
        /// <returns>Product by id</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Products>> GetById(int id)
        {
            var product = await productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        /// <summary>
        /// Function to create a new product
        /// </summary> 
        /// param name="entity">Product</param>
        /// returns>New product id</returns>
        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Insert(Products entity)
        {
            if (entity == null)
            {
                return BadRequest("Product cannot be null");
            }
            
            var response = await productService.Insert(entity);

            if (response > 0)
                return Ok(response);
            return NotFound();
        }

        /// <summary>
        /// Function to update a product
        /// </summary>
        /// param name="id">Product id</param>
        /// returns>Update product</returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> Update(Products entity)
        {
            if (entity == null)
            {
                return BadRequest("Product cannot be null");
            }
            var response = await productService.Update(entity);
            if (response)
                return Ok();
            return NotFound();
        }

        /// <summary>
        /// Function to delete a product
        /// </summary>
        /// param name="id">Product id</param>
        /// returns>Deleted product</returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var product = await productService.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            var response = await productService.Delete(product);
            if (response)
                return Ok();
            return NotFound();
        }
    }
}
