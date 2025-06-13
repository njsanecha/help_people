
namespace HelpPeople.Data.Repository.Generic
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Delete the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        Task<bool> Delete(T entity);
        /// <summary>
        /// Update the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        Task<bool> Update(T entity);
        /// <summary>
        /// Insert the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        Task<int> Insert(T entity);
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<T>> Get();
        /// <summary>
        /// Gets the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        Task<T> GetById(int id);
    }
}
