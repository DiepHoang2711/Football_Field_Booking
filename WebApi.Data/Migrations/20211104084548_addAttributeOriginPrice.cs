using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Data.Migrations
{
    public partial class addAttributeOriginPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "OriginPrice",
                table: "FieldSchedule",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Field",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 4, 15, 45, 47, 969, DateTimeKind.Local).AddTicks(7220),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 4, 10, 40, 13, 538, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 15, 45, 48, 19, DateTimeKind.Local).AddTicks(946));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 15, 45, 48, 19, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 15, 45, 48, 19, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 15, 45, 48, 19, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 15, 45, 48, 19, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 15, 45, 47, 992, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 15, 45, 47, 992, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0d854a38-ea51-4f87-8e05-d7d44db368e1"),
                column: "ConcurrencyStamp",
                value: "d8046684-5709-45c3-9439-045c4c3855e0");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("45a5286c-02e9-4b43-a81f-bb32dceecffd"),
                column: "ConcurrencyStamp",
                value: "08758a2d-a3b1-4e65-afd0-e34475de1cba");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ab1052cc-e279-465d-a9df-25d1795ce0f3"),
                column: "ConcurrencyStamp",
                value: "d2fae6fb-8677-4184-ad14-ec7ea9369169");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "42d8369d-8c8c-45f9-9f15-17f73698a4dc", "AQAAAAEAACcQAAAAEKRK+JBXbW5dor3flvJkXGDpGP8OqOVnlBPPpMAWYBd8bAaWL70cd2V8jMPq8idLqQ==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2d3fb1a2-9e3d-4d50-9fa9-6c92038748d9", "AQAAAAEAACcQAAAAEHCKGg5WGGGhSzVWCQXjCQho2x0b7qpNyrAilKN6AP0WbpMbieOmfksGW1jWZ4h7KQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OriginPrice",
                table: "FieldSchedule");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Field",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 4, 10, 40, 13, 538, DateTimeKind.Local).AddTicks(8917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 4, 15, 45, 47, 969, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 10, 40, 13, 604, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 10, 40, 13, 605, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 10, 40, 13, 605, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 10, 40, 13, 605, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 10, 40, 13, 605, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 10, 40, 13, 574, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 11, 4, 10, 40, 13, 575, DateTimeKind.Local).AddTicks(1223));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0d854a38-ea51-4f87-8e05-d7d44db368e1"),
                column: "ConcurrencyStamp",
                value: "f1f130e5-676f-4243-96ff-c4949f8154ba");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("45a5286c-02e9-4b43-a81f-bb32dceecffd"),
                column: "ConcurrencyStamp",
                value: "d66c093f-ad0f-4325-96b9-b67e546198a6");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ab1052cc-e279-465d-a9df-25d1795ce0f3"),
                column: "ConcurrencyStamp",
                value: "731ef705-2110-40dd-aa65-b48f55c4a086");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6e2fe1e-0533-48de-881f-f03d381ae902", "AQAAAAEAACcQAAAAELM2VZFQn/JTScbGiI7XRQSmdg/FfgQbK4E3N0j1gVNnEMfqhRD3fpTeYtRGRiRNdw==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "70ee1df2-33bf-4653-9342-b91f3b685293", "AQAAAAEAACcQAAAAEIuhsAibbc0866+Xte8B3zew3BbVPhRSXbhaUdDIi7htXrSvwyX1YBE/lwklrXyBBQ==" });
        }
    }
}
