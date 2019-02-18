using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtemisApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WordSets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WordSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Words",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
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
                    { 1, "WordSet {index}" },
                    { 2, "WordSet {index}" },
                    { 3, "WordSet {index}" },
                    { 4, "WordSet {index}" },
                    { 5, "WordSet {index}" },
                    { 6, "WordSet {index}" },
                    { 7, "WordSet {index}" },
                    { 8, "WordSet {index}" },
                    { 9, "WordSet {index}" },
                    { 10, "WordSet {index}" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Words_WordSetId",
                table: "Words",
                column: "WordSetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Words");

            migrationBuilder.DropTable(
                name: "WordSets");
        }
    }
}
