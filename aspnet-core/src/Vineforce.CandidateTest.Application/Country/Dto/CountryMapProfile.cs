using AutoMapper;

namespace Vineforce.CandidateTest.Country.Dto
{
    public class CountryMapProfile : Profile
    {
        public CountryMapProfile()
        {
            CreateMap<CountryDto, Entities.Country>()
                .ForMember(country => country.States, opt => opt.Ignore());

            CreateMap<Entities.Country, CountryDto>();
            CreateMap<CreateCountryDto, Entities.Country>()
                .ForMember(country => country.States, opt => opt.Ignore());
        }
    }
}
