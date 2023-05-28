using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Vineforce.CandidateTest.EntityFrameworkCore;
using Vineforce.CandidateTest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace Vineforce.CandidateTest.Web.Tests
{
    [DependsOn(
        typeof(CandidateTestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class CandidateTestWebTestModule : AbpModule
    {
        public CandidateTestWebTestModule(CandidateTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CandidateTestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(CandidateTestWebMvcModule).Assembly);
        }
    }
}