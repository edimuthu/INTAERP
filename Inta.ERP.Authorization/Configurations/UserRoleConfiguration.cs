using Inta.ERP.Authorization.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Inta.ERP.Authorization.Configurations
{
    public class UserRoleConfiguration: IEntityTypeConfiguration<UserRole<string>>
    {
        public void Configure(EntityTypeBuilder<UserRole<string>> builder)
        {
            //builder.ToTable("UserRole");
            builder.HasData(
                new UserRole<string>
                {
                    RoleId = "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                    UserId = "8e445865-a24d-4543-a6c6-9443d048cdb9",
                    Status = 1
                },
                new UserRole<string>
                {
                    RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                    UserId = "9e224968-33e4-4652-b7b7-8574d048cdb9",
                    Status=1
                }
            );
        }
    }
}
