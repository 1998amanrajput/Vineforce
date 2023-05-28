using Abp.Application.Services.Dto;

namespace Vineforce.CandidateTest.Country.Dto
{
    public class PagedCountryResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
