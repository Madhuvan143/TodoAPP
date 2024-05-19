using Abp.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.ToDos.Dto;

namespace ToDoApp.ToDos
{
    public interface IToDoAppService : IApplicationService
    {
        Task<List<ToDoDto>> GetAll();
        Task<ToDoDto> Get(long id);
        Task Create(CreateToDoDto input);
        Task Update(ToDoDto input);
        Task Delete(long id);
    }
}
