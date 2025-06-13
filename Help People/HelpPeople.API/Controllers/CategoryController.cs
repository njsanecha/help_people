using HelpPeople.Data.Model;
using HelpPeople.Services.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpPeople.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController(ICategoryService categoryService) : ControllerBase
    {
        /// <summary>
        /// Returns the products list of the database
        /// </summary>
        /// <returns>User list</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> Get()
        {
            return Ok(await categoryService.Get());
        }

        /// <summary>
        /// Returns a product by id
        /// </summary>
        /// param name="id">product id</param>
        /// <returns>Product by id</returns>
        [HttpGet]
        [Route("Get/{id}")]
        public async Task<ActionResult<Categories>> GetById(int id)
        {
            var category = await categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        /// <summary>
        /// Function to create a new product
        /// </summary> 
        /// param name="entity">Product</param>
        /// returns>New product id</returns>
        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Insert(Categories entity)
        {
            if (entity == null)
            {
                return BadRequest("Category cannot be null");
            }
            var response = await categoryService.Insert(entity);
                return Ok(response);

        }

        /// <summary>
        /// Function to update a product
        /// </summary>
        /// param name="id">Product id</param>
        /// returns>Update product</returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> Update(Categories entity)
        {
            if (entity == null)
            {
                return BadRequest("Category cannot be null");
            }
            var response = await categoryService.Update(entity);
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
            var category = await categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            var response = await categoryService.Delete(category);
            if (response)
                return Ok();
            return NotFound();
        }
    }
}
