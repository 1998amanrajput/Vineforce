using System.Collections.Generic;

namespace Vineforce.CandidateTest.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
