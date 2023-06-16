using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inta.ERP.Authorization.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "auth");

            migrationBuilder.CreateTable(
                name: "OIDApplications",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClientId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientSecret = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyToken = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ConsentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Permissions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostLogoutRedirectUris = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RedirectUris = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirements = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OIDApplications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OIDScopes",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ConcurrencyToken = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descriptions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisplayNames = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resources = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OIDScopes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedUser = table.Column<int>(type: "int", nullable: false),
                    LastModifiedUser = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    IsApiUser = table.Column<bool>(type: "bit", nullable: false),
                    MaximumApproveAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    MaximumPettyCashApproveAmount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    IsLoggedIn = table.Column<bool>(type: "bit", nullable: false),
                    IsForcedLogoutPending = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedUser = table.Column<int>(type: "int", nullable: false),
                    LastModifiedUser = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OIDAuthorizations",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ConcurrencyToken = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scopes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OIDAuthorizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OIDAuthorizations_OIDApplications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "auth",
                        principalTable: "OIDApplications",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaim_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "auth",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaim_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                schema: "auth",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogin_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                schema: "auth",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedUser = table.Column<int>(type: "int", nullable: false),
                    LastModifiedUser = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRole_Role_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "auth",
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRole_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                schema: "auth",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserToken_User_UserId",
                        column: x => x.UserId,
                        principalSchema: "auth",
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OIDTokens",
                schema: "auth",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ApplicationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    AuthorizationId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ConcurrencyToken = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Payload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Properties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RedemptionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReferenceId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OIDTokens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OIDTokens_OIDApplications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalSchema: "auth",
                        principalTable: "OIDApplications",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OIDTokens_OIDAuthorizations_AuthorizationId",
                        column: x => x.AuthorizationId,
                        principalSchema: "auth",
                        principalTable: "OIDAuthorizations",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "OIDApplications",
                columns: new[] { "Id", "ClientId", "ClientSecret", "ConcurrencyToken", "ConsentType", "DisplayName", "DisplayNames", "Permissions", "PostLogoutRedirectUris", "Properties", "RedirectUris", "Requirements", "Type" },
                values: new object[] { "278d0431-ad6c-41eb-a0ad-d416c7a691b2", "Inta_ERP_Angular_Client", null, "430d10cb-7db5-4869-8240-15fb9da15592", "explicit", "Inta ERP Angular Client PKCE", "{\"fr-FR\":\"Inta ERP Angular Client PKCE\"}", "[\"ept:authorization\", \"ept:logout\", \"ept:token\", \"ept:revocation\", \"gt:authorization_code\", \"gt:refresh_token\", \"rst:code\", \"scp:email\", \"scp:profile\", \"scp:roles\", \"scp:dataEventRecords\"]", "[\"https://localhost:4200\"]", null, "[\"https://localhost:4200\"]", "[\"ft:pkce\"]", "public" });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "OIDScopes",
                columns: new[] { "Id", "ConcurrencyToken", "Description", "Descriptions", "DisplayName", "DisplayNames", "Name", "Properties", "Resources" },
                values: new object[] { "f6cf0665-2e61-4a5b-a764-52aaabc0e33b", "d927480f-274a-4bd9-8d12-4cc360760ed2", null, null, "dataEventRecords API access", "{\"fr-FR\":\"Accès à l'API de démo\"}", "dataEventRecords", null, "[\"rs_dataEventRecordsApi\"]" });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "CreatedUser", "LastModifiedDate", "LastModifiedUser", "Name", "NormalizedName", "Status" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "7138beac-f94b-4348-9846-9a247405ca97", new DateTime(2023, 6, 16, 10, 20, 0, 616, DateTimeKind.Local).AddTicks(1302), 1, new DateTime(2023, 6, 16, 10, 20, 0, 616, DateTimeKind.Local).AddTicks(1311), 1, "Employee", "EMPLOYEE", 0 },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "06e1213a-76ee-451d-bd06-db1a8f8a440e", new DateTime(2023, 6, 16, 10, 20, 0, 616, DateTimeKind.Local).AddTicks(1315), 1, new DateTime(2023, 6, 16, 10, 20, 0, 616, DateTimeKind.Local).AddTicks(1316), 1, "Administrator", "ADMINISTRATOR", 0 }
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "Active", "BranchId", "ConcurrencyStamp", "CreatedDate", "CreatedUser", "Email", "EmailConfirmed", "IsApiUser", "IsForcedLogoutPending", "IsLoggedIn", "LastModifiedDate", "LastModifiedUser", "LockoutEnabled", "LockoutEnd", "MaximumApproveAmount", "MaximumPettyCashApproveAmount", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, true, 0, "5252d78c-42a5-4d8d-808b-9ec6a69ce4ef", new DateTime(2023, 6, 16, 10, 20, 0, 622, DateTimeKind.Local).AddTicks(1509), 1, "admin@localhost.com", true, true, false, false, new DateTime(2023, 6, 16, 10, 20, 0, 622, DateTimeKind.Local).AddTicks(1511), 1, false, null, 0m, 0m, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAED27mXhnbYUvNT+F8xPUzeq66ePERjgYeFAEZed9q5CqH6fYgsUFIiq8V+Q+654dyg==", null, false, "7e491eb7-c79d-4ce8-8041-bd922ab48e97", 1, false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, true, 0, "f89511f4-dda2-435e-85a3-63e781211682", new DateTime(2023, 6, 16, 10, 20, 0, 628, DateTimeKind.Local).AddTicks(1168), 1, "user@localhost.com", true, true, false, false, new DateTime(2023, 6, 16, 10, 20, 0, 628, DateTimeKind.Local).AddTicks(1171), 1, false, null, 0m, 0m, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEFTqDXxV7k/vboXSXtujkfXSJi+F4ldaA64BmQDQILzv5mkWgRL8O5glat8CAdV4Pg==", null, false, "a6b646f7-fcd7-4e06-aeb0-4e4500461337", 1, false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                schema: "auth",
                table: "UserRole",
                columns: new[] { "RoleId", "UserId", "CreatedDate", "CreatedUser", "LastModifiedDate", "LastModifiedUser", "Status" },
                values: new object[,]
                {
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 },
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OIDApplications_ClientId",
                schema: "auth",
                table: "OIDApplications",
                column: "ClientId",
                unique: true,
                filter: "[ClientId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OIDAuthorizations_ApplicationId_Status_Subject_Type",
                schema: "auth",
                table: "OIDAuthorizations",
                columns: new[] { "ApplicationId", "Status", "Subject", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_OIDScopes_Name",
                schema: "auth",
                table: "OIDScopes",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OIDTokens_ApplicationId_Status_Subject_Type",
                schema: "auth",
                table: "OIDTokens",
                columns: new[] { "ApplicationId", "Status", "Subject", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_OIDTokens_AuthorizationId",
                schema: "auth",
                table: "OIDTokens",
                column: "AuthorizationId");

            migrationBuilder.CreateIndex(
                name: "IX_OIDTokens_ReferenceId",
                schema: "auth",
                table: "OIDTokens",
                column: "ReferenceId",
                unique: true,
                filter: "[ReferenceId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "auth",
                table: "Role",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaim_RoleId",
                schema: "auth",
                table: "RoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "auth",
                table: "User",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "auth",
                table: "User",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaim_UserId",
                schema: "auth",
                table: "UserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogin_UserId",
                schema: "auth",
                table: "UserLogin",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRole_RoleId",
                schema: "auth",
                table: "UserRole",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OIDScopes",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "OIDTokens",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "RoleClaim",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "UserClaim",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "UserLogin",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "UserRole",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "UserToken",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "OIDAuthorizations",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "User",
                schema: "auth");

            migrationBuilder.DropTable(
                name: "OIDApplications",
                schema: "auth");
        }
    }
}
