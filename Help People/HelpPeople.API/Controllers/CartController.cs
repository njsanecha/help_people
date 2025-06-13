using HelpPeople.Data.Model;
using HelpPeople.Services.Implementation;
using HelpPeople.Services.Interface;
using HelpPeople.Shared.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpPeople.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController(ICartService cartService) : ControllerBase
    {
        /// <summary>  
        /// Returns the cart items list of the database  
        /// </summary>  
        /// <returns>Cart items list</returns>  
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cart>>> Get()
        {
            return Ok(await cartService.Get());
        }

        /// <summary>  
        /// Returns a cart item by id  
        /// </summary>  
        /// <param name="id">Cart item id</param>  
        /// <returns>Cart item by id</returns>  
        [HttpGet]
        [Route("Get/{id}")]
        public async Task<ActionResult<Cart>> GetById(int id)
        {
            var cartItem = await cartService.GetById(id);
            if (cartItem == null)
            {
                return NotFound();
            }
            return Ok(cartItem);
        }

        /// <summary>  
        /// Function to add a product to the cart  
        /// </summary>   
        /// <param name="entity">Cart item</param>  
        /// <returns>New product to cart</returns>  
        [HttpPost]
        [Route("")]
        public async Task<ActionResult> Insert(Cart entity)
        {
            if (entity == null)
            {
                return BadRequest("Cart item cannot be null");
            }
            var response = await cartService.Insert(entity);
            if (response > 0)
                return Ok(response);
            return NotFound();
        }

        /// <summary>  
        /// Function to checkout the cart items  
        /// </summary>   
        /// <param name="entity">Cart item</param>  
        /// <returns>New checkout</returns>  
        [HttpPost("Checkout")]
        public async Task<IActionResult> Checkout([FromBody] CheckoutRequestDto checkoutRequest)
        {
            if (checkoutRequest == null || checkoutRequest.Items == null || !checkoutRequest.Items.Any())
                return BadRequest("Invalid checkout data.");

            var cartItems = checkoutRequest.Items.Select(i => new Cart
            {
                product_id = i.ProductId,
                quantity = i.Quantity,
                created_at = DateTime.Now,
            }).ToList();

            var response = await cartService.CheckoutAsync(cartItems);

            if (response)
            
                return Ok();

            return BadRequest();
        }
    }
}
