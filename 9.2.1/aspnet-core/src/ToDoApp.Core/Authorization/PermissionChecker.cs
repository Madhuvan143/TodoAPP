using Abp.Authorization;
using ToDoApp.Authorization.Roles;
using ToDoApp.Authorization.Users;

namespace ToDoApp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
