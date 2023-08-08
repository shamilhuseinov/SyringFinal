using System;
namespace DataAccess.UnitOfWork
{
	public interface IUnitOfWork
	{
        Task CommitAsync();
    }
}

