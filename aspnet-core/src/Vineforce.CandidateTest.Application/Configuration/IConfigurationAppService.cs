using System.Threading.Tasks;
using Vineforce.CandidateTest.Configuration.Dto;

namespace Vineforce.CandidateTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
