using System.Threading.Tasks;
using Abp.Application.Services;
using ToDoApp.Authorization.Accounts.Dto;

namespace ToDoApp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
