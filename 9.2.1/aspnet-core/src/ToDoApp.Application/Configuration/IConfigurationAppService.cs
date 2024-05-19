using System.Threading.Tasks;
using ToDoApp.Configuration.Dto;

namespace ToDoApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
