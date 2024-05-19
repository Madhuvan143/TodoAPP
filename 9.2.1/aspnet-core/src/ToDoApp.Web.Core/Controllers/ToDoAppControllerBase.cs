using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ToDoApp.Controllers
{
    public abstract class ToDoAppControllerBase: AbpController
    {
        protected ToDoAppControllerBase()
        {
            LocalizationSourceName = ToDoAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
