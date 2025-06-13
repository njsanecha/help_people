using HelpPeople.Data.Model;
using HelpPeople.Data.Repository.Generic;
using HelpPeople.Services.Generic;
using HelpPeople.Services.Interface;

namespace HelpPeople.Services.Implement
{
    public class UserService : GenericService<Users>, IUserService
    {
        public UserService(IRepository<Users> repository) : base(repository) { }
    }
}
