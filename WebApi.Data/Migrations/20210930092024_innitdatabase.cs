using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Data.Migrations
{
    public partial class innitdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "GroupField",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "GroupField",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "GroupField",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Field",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Field",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 30, 16, 20, 23, 879, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 30, 16, 20, 23, 880, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 30, 16, 20, 23, 880, DateTimeKind.Local).AddTicks(207));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "GroupField");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "GroupField");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "GroupField");

            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Field");

            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Field");

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 9, 26, 16, 47, 36, 517, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 2,
                column: "DateCreated",
                value: new DateTime(2021, 9, 26, 16, 47, 36, 517, DateTimeKind.Local).AddTicks(6077));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 3,
                column: "DateCreated",
                value: new DateTime(2021, 9, 26, 16, 47, 36, 517, DateTimeKind.Local).AddTicks(6110));
        }
    }
}
