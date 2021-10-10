using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Data.Migrations
{
    public partial class configField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "FieldSchedule",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<int>(
                name: "TopHot",
                table: "Field",
                type: "int",
                nullable: false,
                defaultValue: -1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "IsHot",
                table: "Field",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Field",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 10, 19, 36, 48, 2, DateTimeKind.Local).AddTicks(1021),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 10, 19, 36, 48, 35, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 10, 19, 36, 48, 35, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 10, 19, 36, 48, 35, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 10, 19, 36, 48, 35, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 10, 19, 36, 48, 35, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 10, 19, 36, 48, 14, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 10, 19, 36, 48, 14, DateTimeKind.Local).AddTicks(1860));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0d854a38-ea51-4f87-8e05-d7d44db368e1"),
                column: "ConcurrencyStamp",
                value: "8ed3b419-3171-43ec-aa3d-0536d7ff0175");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("45a5286c-02e9-4b43-a81f-bb32dceecffd"),
                column: "ConcurrencyStamp",
                value: "438390dd-b8b8-46c0-bb4d-e2c1b5be3c22");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ab1052cc-e279-465d-a9df-25d1795ce0f3"),
                column: "ConcurrencyStamp",
                value: "367b58e9-104a-4dfc-9293-3c7f222a287f");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9a823003-afe1-436f-9f3e-fd2b5f56ab3b", "AQAAAAEAACcQAAAAEDeCs9GxdrosEI74nmjb3RG7qNOAoielv+aQvQqXVTssFFU7+zd5DvuWIxlaMSvyUA==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a456101-3c60-4bc0-9d40-cb0c6f9e29fc", "AQAAAAEAACcQAAAAEOWT5GX8WKST7+iKAQpwwg1DgRqkNzyVzyeEhygrDe6pM8C85fTc/Y2nEKmuHSXOlg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "FieldSchedule");

            migrationBuilder.AlterColumn<int>(
                name: "TopHot",
                table: "Field",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: -1);

            migrationBuilder.AlterColumn<bool>(
                name: "IsHot",
                table: "Field",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Field",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 10, 19, 36, 48, 2, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 3, 17, 43, 52, 423, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 3, 17, 43, 52, 423, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 3, 17, 43, 52, 423, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 3, 17, 43, 52, 423, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 3, 17, 43, 52, 423, DateTimeKind.Local).AddTicks(8693));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 3, 17, 43, 52, 402, DateTimeKind.Local).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 3, 17, 43, 52, 403, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0d854a38-ea51-4f87-8e05-d7d44db368e1"),
                column: "ConcurrencyStamp",
                value: "025c2433-4faa-4eb7-881d-d5ae93540d0e");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("45a5286c-02e9-4b43-a81f-bb32dceecffd"),
                column: "ConcurrencyStamp",
                value: "39bd001b-83f1-4994-a443-799c6ce92035");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ab1052cc-e279-465d-a9df-25d1795ce0f3"),
                column: "ConcurrencyStamp",
                value: "97738d71-6da8-4fe7-8446-e7c2b4212260");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b550dd39-84aa-493c-86b0-b8b228f193b2", "AQAAAAEAACcQAAAAEDqEwVU6jEZ7XeksvyFgqZ+2rdbQGOwv6YdVNhJOeVXgniPed+Mb+dcNRQxNxWxVQw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3df133a-24dd-43af-bb93-506b4ee2159c", "AQAAAAEAACcQAAAAEJgx45UX9EGsY0LROzOb4jLV71Sy3WbzPUTHgRHSNAgT6sFbEFd9qGlVY5KHGtNgIg==" });
        }
    }
}
