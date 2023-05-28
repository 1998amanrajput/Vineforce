using Abp.Application.Services.Dto;

namespace Vineforce.CandidateTest.State.Dto
{
    public class PageStateResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}
