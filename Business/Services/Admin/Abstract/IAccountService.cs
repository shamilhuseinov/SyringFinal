using System;
using Business.ViewModels.Admin.Account;

namespace Business.Services.Admin.Abstract
{
	public interface IAccountService
	{
		Task<bool> Login(AccountLoginVM model);
	}
}

