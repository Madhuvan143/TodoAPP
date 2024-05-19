using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ToDoApp.Configuration.Dto;

namespace ToDoApp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ToDoAppAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
