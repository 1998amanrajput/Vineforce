using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace Vineforce.CandidateTest.State.Dto
{
    /// <summary>
    /// Dto for state
    /// </summary>
    [AutoMapFrom(typeof(Entities.State))]
    public class StateDto : EntityDto<int>
    {
        /// <summary>
        /// Country Id
        /// </summary>
        public int CountryId { get; set; }
        /// <summary>
        /// Name of state
        /// </summary>
        public string Name { get; set; }
    }
}
