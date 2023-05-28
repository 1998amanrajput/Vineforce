using Abp.Application.Services;
using Abp.Domain.Repositories;
using Vineforce.CandidateTest.Country.Dto;

namespace Vineforce.CandidateTest.Country
{
    public class CountryService : AsyncCrudAppService<Entities.Country, CountryDto, int, PagedCountryResultRequestDto, CreateCountryDto, CountryDto>, ICountryService
    {
        private readonly IRepository<Entities.Country, int> _repository;
        public CountryService(IRepository<Entities.Country, int> repository) : base(repository)
        {
            _repository = repository;
        }
        
    }
}
