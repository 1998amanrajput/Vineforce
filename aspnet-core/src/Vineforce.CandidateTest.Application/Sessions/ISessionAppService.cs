using System.Threading.Tasks;
using Abp.Application.Services;
using Vineforce.CandidateTest.Sessions.Dto;

namespace Vineforce.CandidateTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
