using Abp.Application.Services;
using ToDoApp.MultiTenancy.Dto;

namespace ToDoApp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

