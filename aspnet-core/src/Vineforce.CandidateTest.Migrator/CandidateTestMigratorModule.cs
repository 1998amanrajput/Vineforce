using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Vineforce.CandidateTest.Configuration;
using Vineforce.CandidateTest.EntityFrameworkCore;
using Vineforce.CandidateTest.Migrator.DependencyInjection;

namespace Vineforce.CandidateTest.Migrator
{
    [DependsOn(typeof(CandidateTestEntityFrameworkModule))]
    public class CandidateTestMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public CandidateTestMigratorModule(CandidateTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(CandidateTestMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                CandidateTestConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CandidateTestMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
