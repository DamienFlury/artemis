using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtemisApi.Migrations
{
    public partial class AddDbSetUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 1,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 2,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 3,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 4,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 5,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 6,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 7,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 8,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 10,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 11,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 12,
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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 15,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 16,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 17,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 18,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 19,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 20,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 21,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 22,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 23,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 24,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 25,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 26,
                column: "WordSetId",
                value: 1);

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
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 29,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 30,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 32,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 33,
                column: "WordSetId",
                value: 6);

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
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 38,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 39,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 40,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 41,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 43,
                column: "WordSetId",
                value: 5);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 46,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 47,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 48,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 49,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 51,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 52,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 53,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 54,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 55,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 57,
                column: "WordSetId",
                value: 2);

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
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 61,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 62,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 63,
                column: "WordSetId",
                value: 3);

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
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 66,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 67,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 68,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 70,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 71,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 72,
                column: "WordSetId",
                value: 6);

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
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 75,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 76,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 77,
                column: "WordSetId",
                value: 10);

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
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 81,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 82,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 83,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 84,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 85,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 86,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 87,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 89,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 90,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 91,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 92,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 93,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 95,
                column: "WordSetId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 96,
                column: "WordSetId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 97,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 99,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 100,
                column: "WordSetId",
                value: 4);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 1,
                column: "WordSetId",
                value: 4);

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
                keyValue: 8,
                column: "WordSetId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 10,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 11,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 12,
                column: "WordSetId",
                value: 1);

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
                keyValue: 17,
                column: "WordSetId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 18,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 19,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 20,
                column: "WordSetId",
                value: 4);

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
                keyValue: 23,
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
                keyValue: 49,
                column: "WordSetId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 51,
                column: "WordSetId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 52,
                column: "WordSetId",
                value: 2);

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
                keyValue: 70,
                column: "WordSetId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 71,
                column: "WordSetId",
                value: 10);

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
                keyValue: 86,
                column: "WordSetId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 87,
                column: "WordSetId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 89,
                column: "WordSetId",
                value: 10);

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
                keyValue: 99,
                column: "WordSetId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 100,
                column: "WordSetId",
                value: 1);
        }
    }
}
