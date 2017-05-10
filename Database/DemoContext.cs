using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PutNet.Web.Identity.Database.Identity;

namespace PutNet.Web.Identity.Database
{
    public class DemoContext : IdentityDbContext<User, GuidRole, Guid, GuidUserClaim, GuidUserRole, GuidUserLogin, GuidRoleClaim, GuidUserToken>
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
            
        }
    }
}