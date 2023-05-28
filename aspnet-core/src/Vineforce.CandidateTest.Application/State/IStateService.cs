using Abp.Application.Services;
using Vineforce.CandidateTest.State.Dto;

namespace Vineforce.CandidateTest.State
{
    /// <summary>
    /// Implementation of State Crud
    /// </summary>
    public interface IStateService : IAsyncCrudAppService<StateDto, int, PageStateResultRequestDto, CreateStateDto, StateDto>
    {
    }
}
