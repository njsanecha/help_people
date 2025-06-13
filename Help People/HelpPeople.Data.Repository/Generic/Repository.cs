using Dapper.Contrib.Extensions;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace HelpPeople.Data.Repository.Generic
{
    public class Repository<T> : IRepository<T> where T : class
    {
        /// <summary>
        /// The connection string
        /// </summary>
        protected string _connectionString;

        /// <summary>
        /// Initializes a new instance of the <see cref="Repository{T}"/> class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        public Repository(IConfiguration configuration)
        {
            SqlMapperExtensions.TableNameMapper = (type) => { return $"{type.Name}"; };
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        /// <summary>
        /// Get this instance.
        /// </summary>
        /// <returns></returns>
        public virtual async Task<IEnumerable<T>> Get()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.GetAllAsync<T>();
            }
        }

        /// <summary>
        /// Get the by identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        public virtual async Task<T> GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.GetAsync<T>(id);
            }
        }

        /// <summary>
        /// Insert the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual async Task<int> Insert(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.InsertAsync(entity);
            }
        }

        /// <summary>
        /// Update the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual async Task<bool> Update(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.UpdateAsync(entity);
            }
        }

        /// <summary>
        /// Delete the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public virtual async Task<bool> Delete(T entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return await connection.DeleteAsync(entity);
            }
        }

    }
}
