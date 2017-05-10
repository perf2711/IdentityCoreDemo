using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PutNet.Web.Identity.Database.Identity.Store
{
    public class GuidRoleStore : RoleStore<GuidRole, DemoContext, Guid, GuidUserRole, GuidRoleClaim>
    {
        public GuidRoleStore(DemoContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }

        protected override GuidRoleClaim CreateRoleClaim(GuidRole role, Claim claim)
        {
            return new GuidRoleClaim
            {
                RoleId = role.Id,
                ClaimType = claim.Type,
                ClaimValue = claim.Value
            };
        }
    }
}
