using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Data.Migrations
{
    public partial class addTableDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_Booking_BookingIdForeignKey",
                table: "FeedBack");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_User_UserIdForeignKey",
                table: "FeedBack");

            migrationBuilder.RenameColumn(
                name: "UserIdForeignKey",
                table: "FeedBack",
                newName: "UserForeignKey");

            migrationBuilder.RenameColumn(
                name: "BookingIdForeignKey",
                table: "FeedBack",
                newName: "BookingForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_UserIdForeignKey",
                table: "FeedBack",
                newName: "IX_FeedBack_UserForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_BookingIdForeignKey",
                table: "FeedBack",
                newName: "IX_FeedBack_BookingForeignKey");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Field",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 11, 4, 10, 40, 13, 538, DateTimeKind.Local).AddTicks(8917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 10, 31, 15, 32, 54, 124, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    DiscountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Percent = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.DiscountId);
                });

            migrationBuilder.CreateTable(
                name: "BookingDiscount",
                columns: table => new
                {
                    BookingDiscountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingForeignKey = table.Column<int>(type: "int", nullable: false),
                    DiscountForeignKey = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDiscount", x => x.BookingDiscountId);
                    table.ForeignKey(
                        name: "FK_BookingDiscount_Booking_BookingForeignKey",
                        column: x => x.BookingForeignKey,
                        principalTable: "Booking",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDiscount_Discount_DiscountForeignKey",
                        column: x => x.DiscountForeignKey,
                        principalTable: "Discount",
                        principalColumn: "DiscountId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_BookingDiscount_BookingForeignKey",
                table: "BookingDiscount",
                column: "BookingForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDiscount_DiscountForeignKey",
                table: "BookingDiscount",
                column: "DiscountForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_Booking_BookingForeignKey",
                table: "FeedBack",
                column: "BookingForeignKey",
                principalTable: "Booking",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_User_UserForeignKey",
                table: "FeedBack",
                column: "UserForeignKey",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_Booking_BookingForeignKey",
                table: "FeedBack");

            migrationBuilder.DropForeignKey(
                name: "FK_FeedBack_User_UserForeignKey",
                table: "FeedBack");

            migrationBuilder.DropTable(
                name: "BookingDiscount");

            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.RenameColumn(
                name: "UserForeignKey",
                table: "FeedBack",
                newName: "UserIdForeignKey");

            migrationBuilder.RenameColumn(
                name: "BookingForeignKey",
                table: "FeedBack",
                newName: "BookingIdForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_UserForeignKey",
                table: "FeedBack",
                newName: "IX_FeedBack_UserIdForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_FeedBack_BookingForeignKey",
                table: "FeedBack",
                newName: "IX_FeedBack_BookingIdForeignKey");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Field",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 10, 31, 15, 32, 54, 124, DateTimeKind.Local).AddTicks(9154),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 11, 4, 10, 40, 13, 538, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "Field",
                keyColumn: "FieldId",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 15, 32, 54, 141, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "GroupField",
                keyColumn: "GroupFieldId",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2021, 10, 31, 15, 32, 54, 141, DateTimeKind.Local).AddTicks(5741));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0d854a38-ea51-4f87-8e05-d7d44db368e1"),
                column: "ConcurrencyStamp",
                value: "aacf5f89-c00b-4649-a904-2a9c6ce1b3f5");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("45a5286c-02e9-4b43-a81f-bb32dceecffd"),
                column: "ConcurrencyStamp",
                value: "3ec1b20d-8e5f-4fc9-8d30-f6cb0d83520d");

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ab1052cc-e279-465d-a9df-25d1795ce0f3"),
                column: "ConcurrencyStamp",
                value: "45e52ec5-a2d6-4871-a556-e71f66d34c71");

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31fccde6-5634-4659-aea8-98baa8f306cd", "AQAAAAEAACcQAAAAECwwRdMPDmjNH38nqbmGp3GZS6ItjfeQGVlNt6cpwbbQTDCGYkj7lcq6ok8fp8fK5Q==" });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1cf4084b-7757-4d98-b48b-d6a26ed72fa9", "AQAAAAEAACcQAAAAEHnhkacaOrH/4ofcySbfvt6wb/vW99L6b4moLyAYlMwrjxpGbvm4wDmz00/v0adYjA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_Booking_BookingIdForeignKey",
                table: "FeedBack",
                column: "BookingIdForeignKey",
                principalTable: "Booking",
                principalColumn: "BookingId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FeedBack_User_UserIdForeignKey",
                table: "FeedBack",
                column: "UserIdForeignKey",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
