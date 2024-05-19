using System.Threading.Tasks;
using Abp.Application.Services;
using ToDoApp.Sessions.Dto;

namespace ToDoApp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
