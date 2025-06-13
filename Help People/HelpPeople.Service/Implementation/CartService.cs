using HelpPeople.Data.Model;
using HelpPeople.Data.Repository.Generic;
using HelpPeople.Services.Generic;
using HelpPeople.Services.Interface;

namespace HelpPeople.Services.Implementation
{
    public class CartService : GenericService<Cart>, ICartService
    {
        private readonly IRepository<Cart> _repository;

        public CartService(IRepository<Cart> repository) : base(repository) 
        { 
            _repository = repository;
        }
        public async Task<bool> CheckoutAsync(List<Cart> cartItems)
        {
            try
            {
                foreach (var item in cartItems)
                {
                    item.created_at = DateTime.Now;
                    await _repository.Insert(item);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
