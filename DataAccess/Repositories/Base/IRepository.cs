using System;
using Common.Entities.Base;

namespace DataAccess.Repositories.Base
{
	public interface IRepository<T> where T:BaseEntity
	{
        Task<List<T>> GetAllAsync();

		Task<T> GetAsync(int id);

        Task CreateAssync(T entity);

		void Update(T entity);

		void Delete(T entity);
	}
}

