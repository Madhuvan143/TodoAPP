using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ToDoApp.EntityFrameworkCore;
using ToDoApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ToDoApp.Web.Tests
{
    [DependsOn(
        typeof(ToDoAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ToDoAppWebTestModule : AbpModule
    {
        public ToDoAppWebTestModule(ToDoAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ToDoAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ToDoAppWebMvcModule).Assembly);
        }
    }
}