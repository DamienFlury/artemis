using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtemisApi.Migrations
{
    public partial class AddIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 2,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 3,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 4,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 5,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 6,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 7,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 9,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 13,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 14,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 15,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 16,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 19,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 21,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 22,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 24,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 25,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 26,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 27,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 28,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 29,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 30,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 32,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 33,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 34,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 35,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 36,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 37,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 38,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 39,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 40,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 41,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 42,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 43,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 44,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 45,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 46,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 47,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 48,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 50,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 51,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 53,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 54,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 55,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 56,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 57,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 58,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 59,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 60,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 61,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 62,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 63,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 64,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 65,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 66,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 67,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 68,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 69,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 70,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 72,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 73,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 74,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 75,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 76,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 77,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 78,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 79,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 80,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 81,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 82,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 83,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 84,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 85,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 87,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 88,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 90,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 91,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 92,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 93,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 94,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 95,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 96,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 97,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 98,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 99,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 100,
                column: "WordSetId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 2,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 3,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 4,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 5,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 6,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 7,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 9,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 13,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 14,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 15,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 16,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 19,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 21,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 22,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 24,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 25,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 26,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 27,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 28,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 29,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 30,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 32,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 33,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 34,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 35,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 36,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 37,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 38,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 39,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 40,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 41,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 42,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 43,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 44,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 45,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 46,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 47,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 48,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 50,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 51,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 53,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 54,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 55,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 56,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 57,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 58,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 59,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 60,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 61,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 62,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 63,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 64,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 65,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 66,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 67,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 68,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 69,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 70,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 72,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 73,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 74,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 75,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 76,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 77,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 78,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 79,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 80,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 81,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 82,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 83,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 84,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 85,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 87,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 88,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 90,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 91,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 92,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 93,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 94,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 95,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 96,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 97,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 98,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 99,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 100,
                column: "WordSetId",
                value: 6);
        }
    }
}
