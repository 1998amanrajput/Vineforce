using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Vineforce.CandidateTest.Configuration;

namespace Vineforce.CandidateTest.Web.Host.Startup
{
    [DependsOn(
       typeof(CandidateTestWebCoreModule))]
    public class CandidateTestWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CandidateTestWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CandidateTestWebHostModule).GetAssembly());
        }
    }
}
