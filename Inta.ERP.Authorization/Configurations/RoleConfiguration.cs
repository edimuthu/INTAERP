using Inta.ERP.Authorization.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inta.ERP.Authorization.Configurations
{
    public class RoleConfiguration: IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasData(
                new Role
                {
                    Id = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE",
                    CreatedUser = 1,
                    CreatedDate = DateTime.Now,
                    LastModifiedUser = 1,
                    LastModifiedDate = DateTime.Now
                },
                new Role
                {
                    Id = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR",
                    CreatedUser = 1,
                    CreatedDate = DateTime.Now,
                    LastModifiedUser = 1,
                    LastModifiedDate = DateTime.Now
                }
            );
        }
    }
}
