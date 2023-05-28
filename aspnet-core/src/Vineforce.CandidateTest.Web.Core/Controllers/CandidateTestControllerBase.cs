using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Vineforce.CandidateTest.Controllers
{
    public abstract class CandidateTestControllerBase: AbpController
    {
        protected CandidateTestControllerBase()
        {
            LocalizationSourceName = CandidateTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
