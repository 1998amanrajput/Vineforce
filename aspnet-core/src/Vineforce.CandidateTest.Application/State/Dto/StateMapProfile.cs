using AutoMapper;

namespace Vineforce.CandidateTest.State.Dto
{
    public class StateMapProfile : Profile
    {
        public StateMapProfile()
        {
            CreateMap<StateDto, Entities.State>()
                 .ForMember(x => x.Country, opt => opt.Ignore());
            CreateMap<Entities.State, StateDto>();
            CreateMap<CreateStateDto, Entities.State>().ForMember(x => x.Country, opt => opt.Ignore());
        }
    }
}
