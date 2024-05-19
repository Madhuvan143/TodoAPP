using AutoMapper;

namespace ToDoApp.ToDos.Dto
{
    public class ToDoMapProfile : Profile
    {
        public ToDoMapProfile()
        {
            CreateMap<ToDo, ToDoDto>().ReverseMap();
            CreateMap<CreateToDoDto, ToDo>();
        }
    }
}
