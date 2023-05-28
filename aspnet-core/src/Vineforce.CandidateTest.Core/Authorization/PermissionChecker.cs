using Abp.Authorization;
using Vineforce.CandidateTest.Authorization.Roles;
using Vineforce.CandidateTest.Authorization.Users;

namespace Vineforce.CandidateTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
