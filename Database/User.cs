using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PutNet.Web.Identity.Database.Identity;

namespace PutNet.Web.Identity.Database
{
    public class User : IdentityUser<Guid, GuidUserClaim, GuidUserRole, GuidUserLogin>
    {
        // Override default value
        [Key]
        public override Guid Id { get; set; } = Guid.NewGuid();

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}