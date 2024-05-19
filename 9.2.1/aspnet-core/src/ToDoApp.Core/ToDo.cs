using Abp.Domain.Entities;

namespace ToDoApp
{
    public class ToDo : Entity<long>
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
