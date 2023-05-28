using System.Threading.Tasks;
using Abp.Application.Services;
using Vineforce.CandidateTest.Authorization.Accounts.Dto;

namespace Vineforce.CandidateTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
