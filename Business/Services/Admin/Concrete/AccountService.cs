using Business.Services.Admin.Abstract;
using Business.ViewModels.Admin.Account;
using Common.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Admin.Concrete
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ModelStateDictionary _modelState;

        public AccountService(UserManager<IdentityUser> userManager,
                                IActionContextAccessor contextAccessor)
        {
            _modelState = contextAccessor.ActionContext.ModelState;
            _userManager = userManager;
        }

        public async Task<bool> Login(AccountLoginVM model)
        {
            if (!_modelState.IsValid) return false;

            var user = await _userManager.FindByNameAsync(model.Username);
            if (user is null)
            {
                _modelState.AddModelError(string.Empty, "Username or password is not correct");
                return false;
            }

            if (!await HasAccessToAdminPanelAsync(user))
            {
                _modelState.AddModelError(string.Empty, "No permission");
                return false;
            }

            return true;
        }


        private async Task<bool> HasAccessToAdminPanelAsync(IdentityUser user)
        {
            if (await _userManager.IsInRoleAsync(user, UserRoles.Admin.ToString()) ||
                await _userManager.IsInRoleAsync(user, UserRoles.SuperAdmin.ToString()) ||
                await _userManager.IsInRoleAsync(user, UserRoles.Manager.ToString()) ||
                await _userManager.IsInRoleAsync(user, UserRoles.HR.ToString()))
            {
                return true;
            }
            return false;
        }
    }
}
