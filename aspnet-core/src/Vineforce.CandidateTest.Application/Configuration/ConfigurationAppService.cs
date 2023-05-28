using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Vineforce.CandidateTest.Configuration.Dto;

namespace Vineforce.CandidateTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CandidateTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
