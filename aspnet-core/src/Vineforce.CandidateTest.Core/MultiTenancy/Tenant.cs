using Abp.MultiTenancy;
using Vineforce.CandidateTest.Authorization.Users;

namespace Vineforce.CandidateTest.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
