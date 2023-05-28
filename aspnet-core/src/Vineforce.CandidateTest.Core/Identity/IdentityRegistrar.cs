using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Vineforce.CandidateTest.Authorization;
using Vineforce.CandidateTest.Authorization.Roles;
using Vineforce.CandidateTest.Authorization.Users;
using Vineforce.CandidateTest.Editions;
using Vineforce.CandidateTest.MultiTenancy;

namespace Vineforce.CandidateTest.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
