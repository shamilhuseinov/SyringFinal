using System;
using Common.Entities;
using DataAccess.Repositories.Base;

namespace DataAccess.Repositories.Abstract
{
	public interface ICategoryRepository:IRepository<Category>
	{
		Task<Category> GetByTitleAsync(string title);
	}
}

