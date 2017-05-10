using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace PutNet.Web.Identity.Database
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}