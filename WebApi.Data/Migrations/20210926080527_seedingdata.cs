using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Data.Migrations
{
    public partial class seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroupField",
                columns: table => new
                {
                    GroupFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupField", x => x.GroupFieldId);
                });

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    FieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OriginPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    GroupFieldForeinKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Field", x => x.FieldId);
                    table.ForeignKey(
                        name: "FK_Field_GroupField_GroupFieldForeinKey",
                        column: x => x.GroupFieldForeinKey,
                        principalTable: "GroupField",
                        principalColumn: "GroupFieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GroupField",
                columns: new[] { "GroupFieldId", "Address", "Name", "Status" },
                values: new object[] { 1, "HN", "Hoang", true });

            migrationBuilder.InsertData(
                table: "GroupField",
                columns: new[] { "GroupFieldId", "Address", "Name", "Status" },
                values: new object[] { 2, "HN", "VanTam", true });

            migrationBuilder.InsertData(
                table: "GroupField",
                columns: new[] { "GroupFieldId", "Address", "Name", "Status" },
                values: new object[] { 3, "HN", "MinhAnh", true });

            migrationBuilder.InsertData(
                table: "Field",
                columns: new[] { "FieldId", "Address", "DateCreated", "GroupFieldForeinKey", "Name", "OriginPrice", "Price", "Status" },
                values: new object[] { 1, "HN", new DateTime(2021, 9, 26, 15, 5, 27, 254, DateTimeKind.Local).AddTicks(9319), 1, "A", 10m, 0m, true });

            migrationBuilder.InsertData(
                table: "Field",
                columns: new[] { "FieldId", "Address", "DateCreated", "GroupFieldForeinKey", "Name", "OriginPrice", "Price", "Status" },
                values: new object[] { 2, "HN", new DateTime(2021, 9, 26, 15, 5, 27, 255, DateTimeKind.Local).AddTicks(2860), 2, "A", 10m, 0m, true });

            migrationBuilder.InsertData(
                table: "Field",
                columns: new[] { "FieldId", "Address", "DateCreated", "GroupFieldForeinKey", "Name", "OriginPrice", "Price", "Status" },
                values: new object[] { 3, "HN", new DateTime(2021, 9, 26, 15, 5, 27, 255, DateTimeKind.Local).AddTicks(2894), 3, "A", 10m, 0m, true });

            migrationBuilder.CreateIndex(
                name: "IX_Field_GroupFieldForeinKey",
                table: "Field",
                column: "GroupFieldForeinKey");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "GroupField");
        }
    }
}
