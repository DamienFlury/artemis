using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ArtemisApi.Migrations
{
    public partial class Initial : Migration
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
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WordSets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
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

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Primary = table.Column<string>(nullable: true),
                    Secondary = table.Column<string>(nullable: true),
                    WordSetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Words", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Words_WordSets_WordSetId",
                        column: x => x.WordSetId,
                        principalTable: "WordSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "WordSets",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "WordSet #1" },
                    { 2, "WordSet #2" },
                    { 3, "WordSet #3" },
                    { 4, "WordSet #4" },
                    { 5, "WordSet #5" },
                    { 6, "WordSet #6" },
                    { 7, "WordSet #7" },
                    { 8, "WordSet #8" },
                    { 9, "WordSet #9" },
                    { 10, "WordSet #10" }
                });

            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Primary", "Secondary", "WordSetId" },
                values: new object[,]
                {
                    { 16, "Frontside #16", "Backside #16", 1 },
                    { 53, "Frontside #53", "Backside #53", 8 },
                    { 48, "Frontside #48", "Backside #48", 8 },
                    { 42, "Frontside #42", "Backside #42", 8 },
                    { 27, "Frontside #27", "Backside #27", 8 },
                    { 17, "Frontside #17", "Backside #17", 8 },
                    { 1, "Frontside #1", "Backside #1", 8 },
                    { 100, "Frontside #100", "Backside #100", 7 },
                    { 93, "Frontside #93", "Backside #93", 7 },
                    { 92, "Frontside #92", "Backside #92", 7 },
                    { 80, "Frontside #80", "Backside #80", 7 },
                    { 59, "Frontside #59", "Backside #59", 7 },
                    { 23, "Frontside #23", "Backside #23", 7 },
                    { 99, "Frontside #99", "Backside #99", 6 },
                    { 98, "Frontside #98", "Backside #98", 6 },
                    { 84, "Frontside #84", "Backside #84", 6 },
                    { 83, "Frontside #83", "Backside #83", 6 },
                    { 81, "Frontside #81", "Backside #81", 6 },
                    { 79, "Frontside #79", "Backside #79", 6 },
                    { 78, "Frontside #78", "Backside #78", 6 },
                    { 65, "Frontside #65", "Backside #65", 6 },
                    { 47, "Frontside #47", "Backside #47", 6 },
                    { 54, "Frontside #54", "Backside #54", 8 },
                    { 28, "Frontside #28", "Backside #28", 6 },
                    { 57, "Frontside #57", "Backside #57", 8 },
                    { 10, "Frontside #10", "Backside #10", 9 },
                    { 82, "Frontside #82", "Backside #82", 10 },
                    { 73, "Frontside #73", "Backside #73", 10 },
                    { 71, "Frontside #71", "Backside #71", 10 },
                    { 67, "Frontside #67", "Backside #67", 10 },
                    { 56, "Frontside #56", "Backside #56", 10 },
                    { 43, "Frontside #43", "Backside #43", 10 },
                    { 32, "Frontside #32", "Backside #32", 10 },
                    { 25, "Frontside #25", "Backside #25", 10 },
                    { 3, "Frontside #3", "Backside #3", 10 },
                    { 86, "Frontside #86", "Backside #86", 9 },
                    { 77, "Frontside #77", "Backside #77", 9 },
                    { 75, "Frontside #75", "Backside #75", 9 },
                    { 69, "Frontside #69", "Backside #69", 9 },
                    { 63, "Frontside #63", "Backside #63", 9 },
                    { 62, "Frontside #62", "Backside #62", 9 },
                    { 61, "Frontside #61", "Backside #61", 9 },
                    { 45, "Frontside #45", "Backside #45", 9 },
                    { 33, "Frontside #33", "Backside #33", 9 },
                    { 30, "Frontside #30", "Backside #30", 9 },
                    { 22, "Frontside #22", "Backside #22", 9 },
                    { 12, "Frontside #12", "Backside #12", 9 },
                    { 8, "Frontside #8", "Backside #8", 9 },
                    { 15, "Frontside #15", "Backside #15", 6 },
                    { 6, "Frontside #6", "Backside #6", 6 },
                    { 5, "Frontside #5", "Backside #5", 6 },
                    { 40, "Frontside #40", "Backside #40", 3 },
                    { 36, "Frontside #36", "Backside #36", 3 },
                    { 35, "Frontside #35", "Backside #35", 3 },
                    { 31, "Frontside #31", "Backside #31", 3 },
                    { 11, "Frontside #11", "Backside #11", 3 },
                    { 9, "Frontside #9", "Backside #9", 3 },
                    { 88, "Frontside #88", "Backside #88", 2 },
                    { 87, "Frontside #87", "Backside #87", 2 },
                    { 55, "Frontside #55", "Backside #55", 2 },
                    { 44, "Frontside #44", "Backside #44", 2 },
                    { 41, "Frontside #41", "Backside #41", 2 },
                    { 37, "Frontside #37", "Backside #37", 2 },
                    { 34, "Frontside #34", "Backside #34", 2 },
                    { 26, "Frontside #26", "Backside #26", 2 },
                    { 21, "Frontside #21", "Backside #21", 2 },
                    { 14, "Frontside #14", "Backside #14", 2 },
                    { 89, "Frontside #89", "Backside #89", 1 },
                    { 74, "Frontside #74", "Backside #74", 1 },
                    { 49, "Frontside #49", "Backside #49", 1 },
                    { 29, "Frontside #29", "Backside #29", 1 },
                    { 20, "Frontside #20", "Backside #20", 1 },
                    { 46, "Frontside #46", "Backside #46", 3 },
                    { 66, "Frontside #66", "Backside #66", 3 },
                    { 68, "Frontside #68", "Backside #68", 3 },
                    { 96, "Frontside #96", "Backside #96", 3 },
                    { 4, "Frontside #4", "Backside #4", 6 },
                    { 91, "Frontside #91", "Backside #91", 5 },
                    { 76, "Frontside #76", "Backside #76", 5 },
                    { 72, "Frontside #72", "Backside #72", 5 },
                    { 64, "Frontside #64", "Backside #64", 5 },
                    { 60, "Frontside #60", "Backside #60", 5 },
                    { 58, "Frontside #58", "Backside #58", 5 },
                    { 52, "Frontside #52", "Backside #52", 5 },
                    { 51, "Frontside #51", "Backside #51", 5 },
                    { 50, "Frontside #50", "Backside #50", 5 },
                    { 94, "Frontside #94", "Backside #94", 10 },
                    { 24, "Frontside #24", "Backside #24", 5 },
                    { 2, "Frontside #2", "Backside #2", 5 },
                    { 95, "Frontside #95", "Backside #95", 4 },
                    { 90, "Frontside #90", "Backside #90", 4 },
                    { 85, "Frontside #85", "Backside #85", 4 },
                    { 70, "Frontside #70", "Backside #70", 4 },
                    { 39, "Frontside #39", "Backside #39", 4 },
                    { 38, "Frontside #38", "Backside #38", 4 },
                    { 19, "Frontside #19", "Backside #19", 4 },
                    { 18, "Frontside #18", "Backside #18", 4 },
                    { 7, "Frontside #7", "Backside #7", 4 },
                    { 13, "Frontside #13", "Backside #13", 5 },
                    { 97, "Frontside #97", "Backside #97", 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Words_WordSetId",
                table: "Words",
                column: "WordSetId");
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
                name: "Words");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "WordSets");
        }
    }
}
