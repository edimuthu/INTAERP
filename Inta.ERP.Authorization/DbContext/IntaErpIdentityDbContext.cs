using Inta.ERP.Authorization.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inta.ERP.Authorization.DbContext
{
    public class IntaErpIdentityDbContext: IdentityDbContext<ApplicationUser>
    {
        public IntaErpIdentityDbContext(DbContextOptions<IntaErpIdentityDbContext> options)
        : base(options)
        {
        }

       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
