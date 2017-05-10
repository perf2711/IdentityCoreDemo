using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PutNet.Web.Identity.Database.Identity
{
    public class GuidUserToken : IdentityUserToken<Guid>
    {
        // Add non-existing relation between User and UserToken
        [Key, ForeignKey(nameof(User))]
        public override Guid UserId { get; set; }

        public User User { get; set; }
    }
}
