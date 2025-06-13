using HelpPeople.Data.Model;
using HelpPeople.Data.Repository.Generic;
using HelpPeople.Services.Generic;
using HelpPeople.Services.Interface;

namespace HelpPeople.Services.Implementation
{
    public class ProductService : GenericService<Products>, IProductService
    {
        public ProductService(IRepository<Products> productRepository) : base(productRepository) { }
    }
}
