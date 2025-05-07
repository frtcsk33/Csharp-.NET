using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst3.Migrations
{
    public partial class addSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StudentDetail",
                columns: new[] { "ID", "BirthDay", "CreatedDate", "ModifiedDate", "PhoneNumber", "SchoolNumber", "Status", "StudentID" },
                values: new object[] { 5, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(4376), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "104", 1, 5 });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "ID", "CreatedDate", "FirstName", "Gender", "LastName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(2646), "Emirhan", 1, "Yeşil", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(3299), "Safa", 1, "Başdemir", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 3, new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(3304), "Gürkan", 1, "Taş", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 4, new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(3305), "Zeynep", 2, "Kurt", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "CreatedDate", "ModifiedDate", "Password", "Role", "Status", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 13, 15, 16, 51, 875, DateTimeKind.Local).AddTicks(102), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$4/Y/oiObMEquEYhPjljoTOC7UUB9StFIBkIHifZbBu29gyZdI8YLq", 1, 1, "administrator" },
                    { 2, new DateTime(2024, 7, 13, 15, 16, 51, 876, DateTimeKind.Local).AddTicks(3408), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$sbpq/7GqzXECIBXbIwpdI.qG2QuOj.Xs50dWeGuyuaVzeRAsAHRr2", 2, 1, "abdullah" }
                });

            migrationBuilder.InsertData(
                table: "StudentDetail",
                columns: new[] { "ID", "BirthDay", "CreatedDate", "ModifiedDate", "PhoneNumber", "SchoolNumber", "Status", "StudentID" },
                values: new object[,]
                {
                    { 1, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(3824), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "100", 1, 1 },
                    { 2, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(4369), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "101", 1, 2 },
                    { 3, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(4373), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "102", 1, 3 },
                    { 4, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(4375), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "103", 1, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
