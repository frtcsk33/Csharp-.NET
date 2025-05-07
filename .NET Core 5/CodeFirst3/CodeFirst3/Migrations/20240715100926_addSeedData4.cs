using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst3.Migrations
{
    public partial class addSeedData4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(7674), new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(7677) });

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(7682), new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(7686), new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(7689), new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(7696) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(6237), new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(6242) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(6246), new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(6247) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(6250), new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(6250) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(6252), new DateTime(2024, 7, 15, 13, 9, 25, 636, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 635, DateTimeKind.Local).AddTicks(7126), new DateTime(2024, 7, 15, 13, 9, 25, 635, DateTimeKind.Local).AddTicks(7150), "$2a$11$Y0u31yvS4U1.YAoVLKmpeumdR2tin8ug9Ve6JmSeYGwdYhLY8lFT." });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 15, 13, 9, 25, 635, DateTimeKind.Local).AddTicks(7346), new DateTime(2024, 7, 15, 13, 9, 25, 635, DateTimeKind.Local).AddTicks(7347), "$2a$11$g4c7p2bkAE60LYQl8aALf.28GDWIXZIbbHXU89taHCS8v.55RtLK6" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(3121), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(3681), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(3685), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "StudentDetail",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(3687), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(1722), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(2441), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(2446), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ModifiedDate" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 989, DateTimeKind.Local).AddTicks(2448), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 987, DateTimeKind.Local).AddTicks(4366), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$2/o6gE7NntU6L7aGXhQ8M.oxUAUXSOuQgtWxxDaiEsuLdZtc206Ue" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ModifiedDate", "Password" },
                values: new object[] { new DateTime(2024, 7, 15, 12, 29, 50, 988, DateTimeKind.Local).AddTicks(2492), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "$2a$11$TWwFh6l2knOf/ftnDj6RGusvkKmQici4A/wwExSrzf31tXbOHywcm" });
        }
    }
}
