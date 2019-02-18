using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtemisApi.Migrations
{
    public partial class BetterTitles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "WordSet #1");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "WordSet #2");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "WordSet #3");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "WordSet #4");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "WordSet #5");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "WordSet #6");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "WordSet #7");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "WordSet #8");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "WordSet #9");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "WordSet #10");

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #1", "Backside #1", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #2", "Backside #2", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #3", "Backside #3", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #4", "Backside #4", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #5", "Backside #5", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #6", "Backside #6", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #7", "Backside #7", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #8", "Backside #8", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #9", "Backside #9", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #10", "Backside #10", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #11", "Backside #11", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #12", "Backside #12", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #13", "Backside #13", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #14", "Backside #14", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #15", "Backside #15", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #16", "Backside #16", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #17", "Backside #17", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #18", "Backside #18", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #19", "Backside #19", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #20", "Backside #20", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #21", "Backside #21", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #22", "Backside #22", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #23", "Backside #23", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #24", "Backside #24", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #25", "Backside #25", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #26", "Backside #26", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #27", "Backside #27", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #28", "Backside #28", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #29", "Backside #29", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #30", "Backside #30", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #31", "Backside #31", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #32", "Backside #32", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #33", "Backside #33", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #34", "Backside #34", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #35", "Backside #35", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #36", "Backside #36", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #37", "Backside #37" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #38", "Backside #38", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #39", "Backside #39", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #40", "Backside #40", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #41", "Backside #41" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #42", "Backside #42", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #43", "Backside #43", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #44", "Backside #44", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #45", "Backside #45", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #46", "Backside #46", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #47", "Backside #47", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #48", "Backside #48" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #49", "Backside #49", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #50", "Backside #50", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #51", "Backside #51", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #52", "Backside #52", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #53", "Backside #53", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #54", "Backside #54", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #55", "Backside #55", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #56", "Backside #56", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #57", "Backside #57", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #58", "Backside #58", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #59", "Backside #59", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #60", "Backside #60", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #61", "Backside #61", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #62", "Backside #62", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #63", "Backside #63" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #64", "Backside #64", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #65", "Backside #65", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #66", "Backside #66", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #67", "Backside #67", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #68", "Backside #68", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #69", "Backside #69", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #70", "Backside #70", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #71", "Backside #71", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #72", "Backside #72", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #73", "Backside #73", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #74", "Backside #74", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #75", "Backside #75", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #76", "Backside #76", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #77", "Backside #77", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #78", "Backside #78" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #79", "Backside #79" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #80", "Backside #80" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #81", "Backside #81", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #82", "Backside #82", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #83", "Backside #83" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #84", "Backside #84", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #85", "Backside #85", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #86", "Backside #86", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #87", "Backside #87", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #88", "Backside #88", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #89", "Backside #89", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #90", "Backside #90" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #91", "Backside #91", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #92", "Backside #92", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #93", "Backside #93" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #94", "Backside #94", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside #95", "Backside #95" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #96", "Backside #96", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #97", "Backside #97", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #98", "Backside #98", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #99", "Backside #99", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside #100", "Backside #100", 6 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 3,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 4,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 5,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 6,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 7,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 8,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 9,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "WordSets",
                keyColumn: "Id",
                keyValue: 10,
                column: "Title",
                value: "WordSet {index}");

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $1", "Backside $1", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $2", "Backside $2", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $3", "Backside $3", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $4", "Backside $4", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $5", "Backside $5", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $6", "Backside $6", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $7", "Backside $7", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $8", "Backside $8", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $9", "Backside $9", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $10", "Backside $10", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $11", "Backside $11", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $12", "Backside $12", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $13", "Backside $13", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $14", "Backside $14", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $15", "Backside $15", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $16", "Backside $16", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $17", "Backside $17", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $18", "Backside $18", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $19", "Backside $19", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $20", "Backside $20", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $21", "Backside $21", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $22", "Backside $22", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $23", "Backside $23", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $24", "Backside $24", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $25", "Backside $25", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $26", "Backside $26", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $27", "Backside $27", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $28", "Backside $28", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $29", "Backside $29", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $30", "Backside $30", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $31", "Backside $31", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $32", "Backside $32", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $33", "Backside $33", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $34", "Backside $34", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $35", "Backside $35", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $36", "Backside $36", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $37", "Backside $37" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $38", "Backside $38", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $39", "Backside $39", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $40", "Backside $40", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $41", "Backside $41" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $42", "Backside $42", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $43", "Backside $43", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $44", "Backside $44", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $45", "Backside $45", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $46", "Backside $46", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $47", "Backside $47", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $48", "Backside $48" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $49", "Backside $49", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $50", "Backside $50", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $51", "Backside $51", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $52", "Backside $52", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $53", "Backside $53", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $54", "Backside $54", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $55", "Backside $55", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $56", "Backside $56", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $57", "Backside $57", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $58", "Backside $58", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $59", "Backside $59", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $60", "Backside $60", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $61", "Backside $61", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $62", "Backside $62", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $63", "Backside $63" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $64", "Backside $64", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $65", "Backside $65", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $66", "Backside $66", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $67", "Backside $67", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $68", "Backside $68", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $69", "Backside $69", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $70", "Backside $70", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $71", "Backside $71", 7 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $72", "Backside $72", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $73", "Backside $73", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $74", "Backside $74", 1 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $75", "Backside $75", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $76", "Backside $76", 9 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $77", "Backside $77", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $78", "Backside $78" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $79", "Backside $79" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $80", "Backside $80" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $81", "Backside $81", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $82", "Backside $82", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $83", "Backside $83" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $84", "Backside $84", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $85", "Backside $85", 3 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $86", "Backside $86", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $87", "Backside $87", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $88", "Backside $88", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $89", "Backside $89", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $90", "Backside $90" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $91", "Backside $91", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $92", "Backside $92", 10 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $93", "Backside $93" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $94", "Backside $94", 8 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "Primary", "Secondary" },
                values: new object[] { "Frontside $95", "Backside $95" });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $96", "Backside $96", 5 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $97", "Backside $97", 6 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $98", "Backside $98", 2 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $99", "Backside $99", 4 });

            migrationBuilder.UpdateData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "Primary", "Secondary", "WordSetId" },
                values: new object[] { "Frontside $100", "Backside $100", 4 });
        }
    }
}
