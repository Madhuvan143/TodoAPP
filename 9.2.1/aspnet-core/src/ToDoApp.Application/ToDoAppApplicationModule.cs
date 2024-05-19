using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ToDoApp.Authorization;
using ToDoApp.ToDos.Dto;

namespace ToDoApp
{
    [DependsOn(
        typeof(ToDoAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ToDoAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ToDoAppAuthorizationProvider>();

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                cfg.AddProfile<ToDoMapProfile>();
            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ToDoAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
