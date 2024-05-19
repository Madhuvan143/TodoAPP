using Abp.Application.Services.Dto;

namespace ToDoApp.ToDos.Dto
{
    public class ToDoDto : EntityDto<long>
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
