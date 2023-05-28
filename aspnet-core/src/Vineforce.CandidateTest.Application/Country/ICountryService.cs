using Abp.Application.Services;
using Vineforce.CandidateTest.Country.Dto;

namespace Vineforce.CandidateTest.Country
{
    public interface ICountryService : IAsyncCrudAppService<CountryDto, int, PagedCountryResultRequestDto, CreateCountryDto, CountryDto>
    {
    }
}
