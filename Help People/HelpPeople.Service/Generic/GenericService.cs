using HelpPeople.Data.Repository.Generic;

namespace HelpPeople.Services.Generic
{
    public class GenericService<T>(IRepository<T> repository) : IGenericService<T> where T : class
    {
        public async Task<bool> Delete(T entity)
        {
            return await repository.Delete(entity);
        }

        public async Task<bool> Delete(int id)
        {
            return await repository.Delete(await repository.GetById(id));
        }

        public async Task<IEnumerable<T>> Get()
        {
            return await repository.Get();
        }

        public async Task<T> GetById(int id)
        {
            return await repository.GetById(id);
        }

        public async Task<int> Insert(T entity)
        {
            return await repository.Insert(entity);
        }

        public async Task<bool> Update(T entity)
        {
            return await repository.Update(entity);
        }
    }
}
