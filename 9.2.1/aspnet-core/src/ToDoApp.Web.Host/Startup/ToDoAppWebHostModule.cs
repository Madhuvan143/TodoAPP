using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ToDoApp.Configuration;

namespace ToDoApp.Web.Host.Startup
{
    [DependsOn(
       typeof(ToDoAppWebCoreModule))]
    public class ToDoAppWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ToDoAppWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ToDoAppWebHostModule).GetAssembly());
        }
    }
}
