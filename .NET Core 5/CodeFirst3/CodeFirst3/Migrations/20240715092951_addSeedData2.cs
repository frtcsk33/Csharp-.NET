using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst3.Migrations
{
    public partial class addSeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(3681));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedDate" },
                values: new object[] { new DateTime(1992, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "BirthDay", "CreatedDate" },
                values: new object[] { new DateTime(1990, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 987, DateTimeKind.Local).AddTicks(4366), "$2a$11$2/o6gE7NntU6L7aGXhQ8M.oxUAUXSOuQgtWxxDaiEsuLdZtc206Ue" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 988, DateTimeKind.Local).AddTicks(2492), "$2a$11$TWwFh6l2knOf/ftnDj6RGusvkKmQici4A/wwExSrzf31tXbOHywcm" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(4369));

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "BirthDay", "CreatedDate" },
                values: new object[] { new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "BirthDay", "CreatedDate" },
                values: new object[] { new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.InsertData(
                table: "StudentDetail",
                columns: new[] { "ID", "BirthDay", "CreatedDate", "ModifiedDate", "PhoneNumber", "SchoolNumber", "Status", "StudentID" },
                values: new object[] { 5, new DateTime(1997, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(4376), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "104", 1, 5 });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(3304));

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 13, 15, 16, 51, 877, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 13, 15, 16, 51, 875, DateTimeKind.Local).AddTicks(102), "$2a$11$4/Y/oiObMEquEYhPjljoTOC7UUB9StFIBkIHifZbBu29gyZdI8YLq" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 13, 15, 16, 51, 876, DateTimeKind.Local).AddTicks(3408), "$2a$11$sbpq/7GqzXECIBXbIwpdI.qG2QuOj.Xs50dWeGuyuaVzeRAsAHRr2" });
        }
    }
}
