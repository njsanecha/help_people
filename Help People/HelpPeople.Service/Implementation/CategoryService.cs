using HelpPeople.Data.Model;
using HelpPeople.Data.Repository.Generic;
using HelpPeople.Services.Generic;
using HelpPeople.Services.Interface;

namespace HelpPeople.Services.Implementation
{
    public class CategoryService : GenericService<Categories>, ICategoryService
    {
        public CategoryService(IRepository<Categories> repository) : base(repository) {  }
    }
}
