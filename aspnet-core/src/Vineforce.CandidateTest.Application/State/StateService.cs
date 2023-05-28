using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using System.Threading.Tasks;
using Vineforce.CandidateTest.State.Dto;

namespace Vineforce.CandidateTest.State
{
    public class StateService : AsyncCrudAppService<Entities.State, StateDto, int, PageStateResultRequestDto, CreateStateDto, StateDto>, IStateService
    {
        private readonly IRepository<Entities.State, int> _repository;
        public StateService(IRepository<Entities.State, int> repository) : base(repository)
        {
        }

        public override async Task<StateDto> CreateAsync(CreateStateDto input)
        {
            var state = ObjectMapper.Map<Entities.State>(input);
            var addedEntity = await _repository.InsertAsync(state);
            return ObjectMapper.Map<StateDto>(addedEntity);
        }

        public override Task DeleteAsync(EntityDto<int> input)
        {
            return base.DeleteAsync(input);
        }

        public override Task<PagedResultDto<StateDto>> GetAllAsync(PageStateResultRequestDto input)
        {
            return base.GetAllAsync(input);
        }

        public override Task<StateDto> GetAsync(EntityDto<int> input)
        {
            return base.GetAsync(input);
        }

        public override Task<StateDto> UpdateAsync(StateDto input)
        {
            return base.UpdateAsync(input);
        }

        protected override Task<Entities.State> GetEntityByIdAsync(int id)
        {
            return base.GetEntityByIdAsync(id);
        }
    }
}
