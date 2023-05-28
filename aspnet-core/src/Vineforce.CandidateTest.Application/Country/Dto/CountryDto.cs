using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System.ComponentModel.DataAnnotations;
using Vineforce.CandidateTest.Country.Constants;

namespace Vineforce.CandidateTest.Country.Dto
{
    /// <summary>
    /// Dto for country
    /// </summary>
    [AutoMapFrom(typeof(Entities.Country))]
    public class CountryDto : EntityDto<int>
    {
        /// <summary>
        /// Name of country
        /// </summary>
        [StringLength(CountryConstants.CountryLengthInput)]
        public int Name { get; set; }
    }
}
