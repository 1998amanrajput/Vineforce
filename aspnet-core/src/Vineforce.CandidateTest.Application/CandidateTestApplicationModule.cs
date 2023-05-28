using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Vineforce.CandidateTest.Authorization;

namespace Vineforce.CandidateTest
{
    [DependsOn(
        typeof(CandidateTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CandidateTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CandidateTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CandidateTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
