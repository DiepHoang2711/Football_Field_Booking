using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Data.Migrations
{
    public partial class initdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaim", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserLogin",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogin", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "UserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRole", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "UserToken",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserToken", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OriginPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    UserForeignKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Booking_User_UserForeignKey",
                        column: x => x.UserForeignKey,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupField",
                columns: table => new
                {
                    GroupFieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserForeignKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupField", x => x.GroupFieldId);
                    table.ForeignKey(
                        name: "FK_GroupField_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FeedBack",
                columns: table => new
                {
                    FeedBackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumOfStart = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    BookingIdForeignKey = table.Column<int>(type: "int", nullable: false),
                    UserIdForeignKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBack", x => x.FeedBackId);
                    table.ForeignKey(
                        name: "FK_FeedBack_Booking_BookingIdForeignKey",
                        column: x => x.BookingIdForeignKey,
                        principalTable: "Booking",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FeedBack_User_UserIdForeignKey",
                        column: x => x.UserIdForeignKey,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Field",
                columns: table => new
                {
                    FieldId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TypeField = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2021, 10, 31, 15, 32, 54, 124, DateTimeKind.Local).AddTicks(9154)),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsHot = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    TopHot = table.Column<int>(type: "int", nullable: false, defaultValue: -1),
                    GroupFieldForeinKey = table.Column<int>(type: "int", nullable: false),
                    UserForeignKey = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    table.ForeignKey(
                        name: "FK_Field_User_UserForeignKey",
                        column: x => x.UserForeignKey,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FieldSchedule",
                columns: table => new
                {
                    FieldScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FieldForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldSchedule", x => x.FieldScheduleID);
                    table.ForeignKey(
                        name: "FK_FieldSchedule_Field_FieldForeignKey",
                        column: x => x.FieldForeignKey,
                        principalTable: "Field",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingDetail",
                columns: table => new
                {
                    BookingDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    BookingForeignKey = table.Column<int>(type: "int", nullable: false),
                    FieldScheduleForeignKey = table.Column<int>(type: "int", nullable: false),
                    FieldForeignKey = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingDetail", x => x.BookingDetailId);
                    table.ForeignKey(
                        name: "FK_BookingDetail_Booking_BookingForeignKey",
                        column: x => x.BookingForeignKey,
                        principalTable: "Booking",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDetail_Field_FieldForeignKey",
                        column: x => x.FieldForeignKey,
                        principalTable: "Field",
                        principalColumn: "FieldId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BookingDetail_FieldSchedule_FieldScheduleForeignKey",
                        column: x => x.FieldScheduleForeignKey,
                        principalTable: "FieldSchedule",
                        principalColumn: "FieldScheduleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "GroupField",
                columns: new[] { "GroupFieldId", "Address", "CreatedAt", "Description", "ImageName", "ImagePath", "Name", "Status", "UserForeignKey", "UserId" },
                values: new object[,]
                {
                    { 1, "HN", new DateTime(2021, 10, 31, 15, 32, 54, 141, DateTimeKind.Local).AddTicks(5037), "Sports facilities are the most valuable asset in the business. has always focused on creating more value for its partners. Our system is built on feedback from sports facilities.", null, null, "Hoang", true, new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"), null },
                    { 2, "HN", new DateTime(2021, 10, 31, 15, 32, 54, 141, DateTimeKind.Local).AddTicks(5741), "Sports facilities are the most valuable asset in the business. has always focused on creating more value for its partners. Our system is built on feedback from sports facilities.", null, null, "VanTam", true, new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"), null }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("ab1052cc-e279-465d-a9df-25d1795ce0f3"), "45e52ec5-a2d6-4871-a556-e71f66d34c71", "Admin is boss", "ADMIN", null },
                    { new Guid("0d854a38-ea51-4f87-8e05-d7d44db368e1"), "aacf5f89-c00b-4649-a904-2a9c6ce1b3f5", "Owner is manager", "OWNER", null },
                    { new Guid("45a5286c-02e9-4b43-a81f-bb32dceecffd"), "3ec1b20d-8e5f-4fc9-8d30-f6cb0d83520d", "User is user", "USER", null }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DoB", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9"), 0, "1cf4084b-7757-4d98-b48b-d6a26ed72fa9", new DateTime(1998, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoangbd@gmail.com", false, "Bach Duy", "Hoang", false, null, null, null, "AQAAAAEAACcQAAAAEHnhkacaOrH/4ofcySbfvt6wb/vW99L6b4moLyAYlMwrjxpGbvm4wDmz00/v0adYjA==", "09356248153", false, null, false, null },
                    { new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb"), 0, "31fccde6-5634-4659-aea8-98baa8f306cd", new DateTime(2000, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "tamnv@gmail.com", false, "Nguyen Van", "Tam", false, null, null, null, "AQAAAAEAACcQAAAAECwwRdMPDmjNH38nqbmGp3GZS6ItjfeQGVlNt6cpwbbQTDCGYkj7lcq6ok8fp8fK5Q==", "096589475135", false, null, false, null }
                });

            migrationBuilder.InsertData(
                table: "Field",
                columns: new[] { "FieldId", "Address", "CreatedAt", "DeletedAt", "GroupFieldForeinKey", "ImageName", "ImagePath", "IsHot", "Name", "Status", "TopHot", "TypeField", "UserForeignKey" },
                values: new object[,]
                {
                    { 1, "HN", new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(4166), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, true, "A", true, 1, 5, new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9") },
                    { 2, "HN", new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(6098), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, true, "B", true, 3, 5, new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9") },
                    { 3, "HN", new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(6171), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, true, "C", true, 2, 7, new Guid("76d27679-bf33-43ce-abeb-5c85341cc1b9") },
                    { 4, "HN", new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(6175), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, true, "A", true, 1, 5, new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb") },
                    { 5, "HN", new DateTime(2021, 10, 31, 15, 32, 54, 162, DateTimeKind.Local).AddTicks(6178), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, null, true, "B", true, 2, 11, new Guid("66fb69ca-8a82-46bf-b2cf-4101db00cccb") }
                });

            migrationBuilder.InsertData(
                table: "FieldSchedule",
                columns: new[] { "FieldScheduleID", "FieldForeignKey", "Price", "Status", "TimeEnd", "TimeStart" },
                values: new object[,]
                {
                    { 1, 1, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 2, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 3, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 4, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 5, 0m, true, new DateTime(2021, 4, 10, 23, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 10, 5, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_UserForeignKey",
                table: "Booking",
                column: "UserForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetail_BookingForeignKey",
                table: "BookingDetail",
                column: "BookingForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetail_FieldForeignKey",
                table: "BookingDetail",
                column: "FieldForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_BookingDetail_FieldScheduleForeignKey",
                table: "BookingDetail",
                column: "FieldScheduleForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_BookingIdForeignKey",
                table: "FeedBack",
                column: "BookingIdForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBack_UserIdForeignKey",
                table: "FeedBack",
                column: "UserIdForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_Field_GroupFieldForeinKey",
                table: "Field",
                column: "GroupFieldForeinKey");

            migrationBuilder.CreateIndex(
                name: "IX_Field_UserForeignKey",
                table: "Field",
                column: "UserForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_FieldSchedule_FieldForeignKey",
                table: "FieldSchedule",
                column: "FieldForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_GroupField_UserId",
                table: "GroupField",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingDetail");

            migrationBuilder.DropTable(
                name: "FeedBack");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "RoleClaim");

            migrationBuilder.DropTable(
                name: "UserClaim");

            migrationBuilder.DropTable(
                name: "UserLogin");

            migrationBuilder.DropTable(
                name: "UserRole");

            migrationBuilder.DropTable(
                name: "UserToken");

            migrationBuilder.DropTable(
                name: "FieldSchedule");

            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "Field");

            migrationBuilder.DropTable(
                name: "GroupField");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
