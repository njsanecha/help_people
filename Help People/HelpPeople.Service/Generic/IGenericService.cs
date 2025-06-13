
namespace HelpPeople.Services.Generic
{
    public interface IGenericService<T> where T : class
    {
        Task<bool> Delete(T entity);
        Task<bool> Delete(int id);
        Task<bool> Update(T entity);
        Task<int> Insert(T entity);
        Task<IEnumerable<T>> Get();
        Task<T> GetById(int id);
    }
}
