using System.ComponentModel.DataAnnotations;

namespace ToDoApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}