using Abp.Application.Services.Dto;

namespace Vineforce.CandidateTest.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

