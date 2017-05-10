using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PutNet.Web.Identity.Database.Identity
{
    public class GuidRole : IdentityRole<Guid, GuidUserRole, GuidRoleClaim>
    {
    }
}
