using HelpPeople.Data.Model;
using HelpPeople.Services.Generic;

namespace HelpPeople.Services.Interface
{
    public interface ICartService : IGenericService<Cart>
    {
        Task<bool> CheckoutAsync(List<Cart> cartItems);
    }
}
