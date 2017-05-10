using System;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PutNet.Web.Identity.Database.Identity.Store
{
    public class GuidUserStore : UserStore<User, GuidRole, DemoContext, Guid, GuidUserClaim, GuidUserRole, GuidUserLogin, GuidUserToken, GuidRoleClaim>
    {
        public GuidUserStore(DemoContext context, IdentityErrorDescriber describer = null) : base(context, describer)
        {
        }

        protected override GuidUserRole CreateUserRole(User user, GuidRole role)
        {
            return new GuidUserRole
            {
                UserId = user.Id,
                RoleId = role.Id
            };
        }

        protected override GuidUserClaim CreateUserClaim(User user, Claim claim)
        {
            return new GuidUserClaim
            {
                UserId = user.Id,
                ClaimType = claim.Type,
                ClaimValue = claim.Value
            };
        }

        protected override GuidUserLogin CreateUserLogin(User user, UserLoginInfo login)
        {
            return new GuidUserLogin
            {
                UserId = user.Id,
                LoginProvider = login.LoginProvider,
                ProviderDisplayName = login.ProviderDisplayName,
                ProviderKey = login.ProviderKey
            };
        }

        protected override GuidUserToken CreateUserToken(User user, string loginProvider, string name, string value)
        {
            return new GuidUserToken
            {
                UserId = user.Id,
                User = user,
                LoginProvider = loginProvider,
                Name = name,
                Value = value
            };
        }
    }
}
