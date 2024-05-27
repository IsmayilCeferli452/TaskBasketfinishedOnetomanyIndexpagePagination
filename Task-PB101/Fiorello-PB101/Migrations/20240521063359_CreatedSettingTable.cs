using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorello_PB101.Migrations
{
    public partial class CreatedSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8346));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8349));

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "CreatedDate", "Key", "SoftDeleted", "Value" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8229), "HeaderLogo", false, "logo.png" },
                    { 2, new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8231), "Phone", false, "234892348" },
                    { 3, new DateTime(2024, 5, 21, 10, 33, 59, 445, DateTimeKind.Local).AddTicks(8233), "Address", false, "Ehmedli" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 9, 27, 45, 178, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 9, 27, 45, 178, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 5, 15, 9, 27, 45, 178, DateTimeKind.Local).AddTicks(4597));
        }
    }
}
