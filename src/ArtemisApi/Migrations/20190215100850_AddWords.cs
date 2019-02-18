using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtemisApi.Migrations
{
    public partial class AddWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Words",
                columns: new[] { "Id", "Primary", "Secondary", "WordSetId" },
                values: new object[,]
                {
                    { 1, "Frontside $1", "Backside $1", 8 },
                    { 73, "Frontside $73", "Backside $73", 8 },
                    { 72, "Frontside $72", "Backside $72", 3 },
                    { 71, "Frontside $71", "Backside $71", 7 },
                    { 70, "Frontside $70", "Backside $70", 7 },
                    { 69, "Frontside $69", "Backside $69", 8 },
                    { 68, "Frontside $68", "Backside $68", 1 },
                    { 67, "Frontside $67", "Backside $67", 10 },
                    { 66, "Frontside $66", "Backside $66", 3 },
                    { 65, "Frontside $65", "Backside $65", 7 },
                    { 64, "Frontside $64", "Backside $64", 10 },
                    { 63, "Frontside $63", "Backside $63", 10 },
                    { 62, "Frontside $62", "Backside $62", 8 },
                    { 61, "Frontside $61", "Backside $61", 1 },
                    { 60, "Frontside $60", "Backside $60", 5 },
                    { 59, "Frontside $59", "Backside $59", 3 },
                    { 58, "Frontside $58", "Backside $58", 5 },
                    { 57, "Frontside $57", "Backside $57", 3 },
                    { 56, "Frontside $56", "Backside $56", 4 },
                    { 55, "Frontside $55", "Backside $55", 6 },
                    { 54, "Frontside $54", "Backside $54", 4 },
                    { 53, "Frontside $53", "Backside $53", 4 },
                    { 74, "Frontside $74", "Backside $74", 1 },
                    { 52, "Frontside $52", "Backside $52", 1 },
                    { 75, "Frontside $75", "Backside $75", 5 },
                    { 77, "Frontside $77", "Backside $77", 4 },
                    { 98, "Frontside $98", "Backside $98", 2 },
                    { 97, "Frontside $97", "Backside $97", 6 },
                    { 96, "Frontside $96", "Backside $96", 5 },
                    { 95, "Frontside $95", "Backside $95", 4 },
                    { 94, "Frontside $94", "Backside $94", 8 },
                    { 93, "Frontside $93", "Backside $93", 7 },
                    { 92, "Frontside $92", "Backside $92", 10 },
                    { 91, "Frontside $91", "Backside $91", 5 },
                    { 90, "Frontside $90", "Backside $90", 8 },
                    { 89, "Frontside $89", "Backside $89", 8 },
                    { 88, "Frontside $88", "Backside $88", 6 },
                    { 87, "Frontside $87", "Backside $87", 6 },
                    { 86, "Frontside $86", "Backside $86", 5 },
                    { 85, "Frontside $85", "Backside $85", 3 },
                    { 84, "Frontside $84", "Backside $84", 10 },
                    { 83, "Frontside $83", "Backside $83", 7 },
                    { 82, "Frontside $82", "Backside $82", 4 },
                    { 81, "Frontside $81", "Backside $81", 10 },
                    { 80, "Frontside $80", "Backside $80", 2 },
                    { 79, "Frontside $79", "Backside $79", 2 },
                    { 78, "Frontside $78", "Backside $78", 2 },
                    { 76, "Frontside $76", "Backside $76", 9 },
                    { 51, "Frontside $51", "Backside $51", 4 },
                    { 50, "Frontside $50", "Backside $50", 6 },
                    { 49, "Frontside $49", "Backside $49", 1 },
                    { 22, "Frontside $22", "Backside $22", 4 },
                    { 21, "Frontside $21", "Backside $21", 4 },
                    { 20, "Frontside $20", "Backside $20", 8 },
                    { 19, "Frontside $19", "Backside $19", 5 },
                    { 18, "Frontside $18", "Backside $18", 10 },
                    { 17, "Frontside $17", "Backside $17", 2 },
                    { 16, "Frontside $16", "Backside $16", 2 },
                    { 15, "Frontside $15", "Backside $15", 4 },
                    { 14, "Frontside $14", "Backside $14", 9 },
                    { 13, "Frontside $13", "Backside $13", 4 },
                    { 12, "Frontside $12", "Backside $12", 9 },
                    { 11, "Frontside $11", "Backside $11", 2 },
                    { 10, "Frontside $10", "Backside $10", 3 },
                    { 9, "Frontside $9", "Backside $9", 6 },
                    { 8, "Frontside $8", "Backside $8", 5 },
                    { 7, "Frontside $7", "Backside $7", 6 },
                    { 6, "Frontside $6", "Backside $6", 10 },
                    { 5, "Frontside $5", "Backside $5", 3 },
                    { 4, "Frontside $4", "Backside $4", 7 },
                    { 3, "Frontside $3", "Backside $3", 3 },
                    { 2, "Frontside $2", "Backside $2", 5 },
                    { 23, "Frontside $23", "Backside $23", 2 },
                    { 24, "Frontside $24", "Backside $24", 8 },
                    { 25, "Frontside $25", "Backside $25", 5 },
                    { 26, "Frontside $26", "Backside $26", 8 },
                    { 48, "Frontside $48", "Backside $48", 7 },
                    { 47, "Frontside $47", "Backside $47", 9 },
                    { 46, "Frontside $46", "Backside $46", 3 },
                    { 45, "Frontside $45", "Backside $45", 6 },
                    { 44, "Frontside $44", "Backside $44", 1 },
                    { 43, "Frontside $43", "Backside $43", 1 },
                    { 42, "Frontside $42", "Backside $42", 6 },
                    { 41, "Frontside $41", "Backside $41", 3 },
                    { 40, "Frontside $40", "Backside $40", 4 },
                    { 39, "Frontside $39", "Backside $39", 3 },
                    { 99, "Frontside $99", "Backside $99", 4 },
                    { 38, "Frontside $38", "Backside $38", 10 },
                    { 36, "Frontside $36", "Backside $36", 8 },
                    { 35, "Frontside $35", "Backside $35", 1 },
                    { 34, "Frontside $34", "Backside $34", 3 },
                    { 33, "Frontside $33", "Backside $33", 9 },
                    { 32, "Frontside $32", "Backside $32", 10 },
                    { 31, "Frontside $31", "Backside $31", 6 },
                    { 30, "Frontside $30", "Backside $30", 7 },
                    { 29, "Frontside $29", "Backside $29", 6 },
                    { 28, "Frontside $28", "Backside $28", 8 },
                    { 27, "Frontside $27", "Backside $27", 10 },
                    { 37, "Frontside $37", "Backside $37", 5 },
                    { 100, "Frontside $100", "Backside $100", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Words",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
