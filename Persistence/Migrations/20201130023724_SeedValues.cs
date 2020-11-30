using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Distance", "Name" },
                values: new object[] { 1, "25 yards", "Name 101" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Distance", "Name" },
                values: new object[] { 2, "30 yards", "Name 102" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Distance", "Name" },
                values: new object[] { 3, "50 yards", "Name 103" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
