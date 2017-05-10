using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PutNet.Web.Identity.Database
{
    public class DemoContext : IdentityDbContext<User>
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
            
        }
    }
}