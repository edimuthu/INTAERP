using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OpenIddict.EntityFrameworkCore.Models;
using static OpenIddict.Abstractions.OpenIddictConstants;

namespace Inta.ERP.Authorization.Configurations
{
    public class OIDScopeConfiguration: IEntityTypeConfiguration<OpenIddictEntityFrameworkCoreScope>
    {
        public void Configure(EntityTypeBuilder<OpenIddictEntityFrameworkCoreScope> builder)
        {
            builder.HasData(
                new OpenIddictEntityFrameworkCoreScope
                {
                    DisplayName= "dataEventRecords API access",
                    DisplayNames= "{\"fr-FR\":\"Accès à l'API de démo\"}",
                    Name= "dataEventRecords",
                    Resources= "[\"rs_dataEventRecordsApi\"]"

                }
            );
        }
    }
}
