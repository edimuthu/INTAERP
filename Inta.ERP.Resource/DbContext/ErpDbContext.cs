using Inta.ERP.Resource.Entity;
using Microsoft.EntityFrameworkCore;

namespace Inta.ERP.Resource.DbContext
{
    public class ErpDbContext: Microsoft.EntityFrameworkCore.DbContext
    {
        public ErpDbContext(DbContextOptions<ErpDbContext> options) : base(options) { }

        public DbSet<DataEventRecord> DataEventRecords => Set<DataEventRecord>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<DataEventRecord>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
