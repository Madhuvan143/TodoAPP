using Abp.Application.Services;
using Abp.Domain.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.ToDos.Dto;

namespace ToDoApp.ToDos
{
    public class ToDoAppService : ApplicationService, IToDoAppService
    {
        private readonly IRepository<ToDo, long> _toDoRepository;

        public ToDoAppService(IRepository<ToDo, long> toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }

        public async Task<List<ToDoDto>> GetAll()
        {
            var toDos = await _toDoRepository.GetAllListAsync();
            return ObjectMapper.Map<List<ToDoDto>>(toDos);
        }

        public async Task<ToDoDto> Get(long id)
        {
            var toDo = await _toDoRepository.GetAsync(id);
            return ObjectMapper.Map<ToDoDto>(toDo);
        }

        public async Task Create(CreateToDoDto input)
        {
            var toDo = ObjectMapper.Map<ToDo>(input);
            await _toDoRepository.InsertAsync(toDo);
        }

        public async Task Update(ToDoDto input)
        {
            var toDo = await _toDoRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, toDo);
            await _toDoRepository.UpdateAsync(toDo);
        }

        public async Task Delete(long id)
        {
            await _toDoRepository.DeleteAsync(id);
        }
    }

}
