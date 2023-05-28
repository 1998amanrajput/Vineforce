using Abp.Application.Services;
using Vineforce.CandidateTest.MultiTenancy.Dto;

namespace Vineforce.CandidateTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

