using Inta.ERP.Authorization.Configurations;
using Inta.ERP.Authorization.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OpenIddict.Abstractions;
using OpenIddict.EntityFrameworkCore.Models;
using System.Data;
using System.Reflection;
using System.Reflection.Emit;
using System.Xml;

namespace Inta.ERP.Authorization.DbContext
{
    public class IntaErpIdentityDbContext: IdentityDbContext<User, Role,string, IdentityUserClaim<string>, UserRole<string>, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public virtual DbSet<Role> Roles { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public IntaErpIdentityDbContext(DbContextOptions<IntaErpIdentityDbContext> options)
        : base(options)
        {
        }

       
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
            builder.HasDefaultSchema("auth");
            //builder.ApplyConfiguration(new ApplicationERPConfiguration());
            builder.Entity<User>(entity =>
            {
                entity.ToTable(name: "User");
                //entity.HasKey(x => x.Id).HasName("UserId");
                entity.Property(e => e.MaximumApproveAmount).HasPrecision(18, 2);
                entity.Property(e => e.MaximumPettyCashApproveAmount).HasPrecision(18, 2);
            });
            builder.Entity<Role>(entity =>
            {
                entity.ToTable(name: "Role");
            });
            builder.Entity<UserRole<string>>(entity =>
            {
                entity.ToTable(name: "UserRole");
            });

            builder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable(name: "UserToken");
            });

            builder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable(name: "UserClaim");
            });

            builder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable(name: "RoleClaim");
            });

            builder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable(name: "UserLogin");
            });

            builder.Entity<OpenIddictEntityFrameworkCoreApplication>(entity =>
            {
                entity.ToTable(name: "OIDApplications"); // rename the default table OpenIddictApplications
            });
            builder.Entity<OpenIddictEntityFrameworkCoreAuthorization>(entity =>
            {
                entity.ToTable(name: "OIDAuthorizations"); // rename the default table OpenIddictAuthorizations
            });
            builder.Entity<OpenIddictEntityFrameworkCoreScope>(entity =>
            {
                entity.ToTable(name: "OIDScopes"); // rename the default table OpenIddictScopes
            });
            builder.Entity<OpenIddictEntityFrameworkCoreToken>(entity =>
            {
                entity.ToTable(name: "OIDTokens"); // rename the default table OpenIddictTokens
            });
            //builder.Entity<OpenIddictApplicationDescriptor>(entity =>
            //{
            //    entity.ToTable(name: "ApplicationsERP");
            //});
            //builder.Ignore<IdentityUserToken<string>>();
            //builder.Ignore<IdentityUserClaim<string>>();
            //builder.Ignore<IdentityRoleClaim<string>>();
            //builder.Ignore<IdentityUserLogin<string>>();
            //builder.Entity<ApplicationUserRole>(userRole =>
            //{
            //    userRole.HasOne(ur => ur.Role)
            //        .WithMany()
            //        .HasForeignKey(ur => ur.RoleId)
            //        .IsRequired();

            //    userRole.HasOne(ur => ur.User)
            //        .WithMany()
            //        .HasForeignKey(ur => ur.UserId)
            //        .IsRequired();

            //    // Configure the key on the base type
            //    userRole.OwnsOne(ur => ur.Role).HasKey(r => r.RoleId);
            //});
            //base.OnModelCreating(builder);
            //builder.Entity<IdentityUserLogin<string>>(b =>
            //{
            //    b.ToTable("UserLogin");
            //    b.HasNoKey();
            //});
            //builder.Entity<IdentityUserToken<string>>(b =>
            //{
            //    b.ToTable("UserToken");
            //    b.HasNoKey();
            //});
            //builder.Entity<ApplicationUserRole>(b =>
            //{
            //    b.ToTable("UserRole");
            //    b.HasNoKey();
            //});
            //builder.Entity<ApplicationUser>(b =>
            //{
            //    b.ToTable("Users");
            //});

            //builder.Entity<ApplicationRole>(b =>
            //{
            //    b.ToTable("Roles");
            //});

            ////builder.Entity<ApplicationRole>(entity =>
            ////{
            ////    entity.ToTable("Roles");
            ////    entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
            ////        .IsUnique()
            ////        .HasFilter("([NormalizedName] IS NOT NULL)");

            ////    entity.Property(e => e.Name).HasMaxLength(256);
            ////    entity.Property(e => e.NormalizedName).HasMaxLength(256);

            ////});

            ////builder.Entity<ApplicationUser>(entity =>
            ////{
            ////    entity.ToTable("Users");
            ////    entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

            ////    entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
            ////        .IsUnique()
            ////        .HasFilter("([NormalizedUserName] IS NOT NULL)");

            ////    entity.Property(e => e.Email).HasMaxLength(256);
            ////    entity.Property(e => e.NormalizedEmail).HasMaxLength(256);
            ////    entity.Property(e => e.NormalizedUserName).HasMaxLength(256);
            ////    entity.Property(e => e.UserName).HasMaxLength(256);

            ////    entity.HasMany(d => d.Roles).WithMany(p => p.Users)
            ////        .UsingEntity<Dictionary<string, object>>(
            ////            "UserRole",
            ////            r => r.HasOne<ApplicationRole>().WithMany().HasForeignKey("RoleId"),
            ////            l => l.HasOne<ApplicationUser>().WithMany().HasForeignKey("UserId"),
            ////            j =>
            ////            {
            ////                j.HasKey("UserId", "RoleId");
            ////                j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
            ////            });
            ////});

            //builder.ApplyConfigurationsFromAssembly(typeof(IntaErpIdentityDbContext).Assembly);
        }
    }
}
