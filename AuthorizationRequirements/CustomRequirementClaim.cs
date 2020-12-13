/*using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basics.AuthorizationRequirements
{
    public class CustomRequirementClaim : IAuthorizationRequirement
    {
        public CustomRequirementClaim(string claimType)
        {
            ClaimType = claimType;
        }
        public string ClaimType { get; }

        public class CustomRequirementClaimHandler : AuthorizationHandler<CustomRequirementClaim>
        {
            protected override Task HandleRequirementAsync(
                AuthorizationHandlerContext context,
                CustomRequirementClaim requirement)
            {
                var hasClaim = context.User.Claims.Any(x => x.Type == requirement.ClaimType);

                if (hasClaim)
                {
                    context.Succeed(requirement);
                }

                return Task.CompletedTask;
            }
        }
    }
    public static class AuthorizationPolicyBuilderExtensions
    {
        public static AuthorizationPolicyBuilder RequirementCustomClaim(
            this AuthorizationPolicyBuilder builder,
            string claimType)
        {
            builder.AddRequirements(new CustomRequirementClaim(claimType));
            return builder;
        }
    }
}
*/