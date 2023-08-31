using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserMangment.Migrations
{
    public partial class adduserrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f5563dd4-049c-41b5-b0df-75a5b0dbabef");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d80ae6e3-f71d-42eb-89e8-9eed23cedceb");

            migrationBuilder.InsertData(
                schema: "security",
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "3b765cc1-10f6-449c-b06b-02dac2f3f026" },
                    { "2", "fe24acab-b235-4d75-b263-b1dcb6343c61" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "3b765cc1-10f6-449c-b06b-02dac2f3f026" });

            migrationBuilder.DeleteData(
                schema: "security",
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "fe24acab-b235-4d75-b263-b1dcb6343c61" });

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ff774cdf-2660-4acf-98a1-7bc030ad30e1");

            migrationBuilder.UpdateData(
                schema: "security",
                table: "Roles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "76789ad8-3282-488d-948c-7a6347ffaaf7");
        }
    }
}
