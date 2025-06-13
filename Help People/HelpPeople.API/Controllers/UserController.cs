using HelpPeople.Data.Model;
using HelpPeople.Services.Generic;
using HelpPeople.Services.Interface;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpPeople.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {

        /// <summary>
        /// Returns the users list of the database
        /// </summary>
        /// <returns>User list</returns>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Users>>> Get()
        {
            return Ok(await userService.Get());
        }

        /// <summary>
        /// Returns a user by id
        /// </summary>
        /// param name="id">User id</param>
        /// <returns>User by id</returns>
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<Users>> GetById(int id)
        {
            var user = await userService.GetById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        /// <summary>
        /// Function to create a new user
        /// </summary> 
        /// param name="entity">User</param>
        /// returns>New user id</returns>
        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Insert(Users entity)
        {
            if (entity == null)
            {
                return BadRequest("User cannot be null");
            }
            var response = await userService.Insert(entity);

            if (response > 0)
                return Ok(response);
            return NotFound();
        }

        /// <summary>
        /// Function to update a user
        /// </summary>
        /// param name="id">User id</param>
        /// returns>Update user</returns>
        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult> Update(Users entity)
        {
            if (entity == null)
            {
                return BadRequest("User cannot be null");
            }
            var response = await userService.Update(entity);
            if (response)
                return Ok();
            return NotFound();
        }

        /// <summary>
        /// Function to delete a user
        /// </summary>
        /// param name="id">User id</param>
        /// returns>Delete user</returns>
        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var response = await userService.Delete(id);
            if (response)
                return Ok();
            return NotFound();
        }
    }
}
