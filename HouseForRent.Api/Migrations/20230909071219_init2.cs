using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseForRent.Api.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Guests",
                columns: new[] { "Id", "Address", "BirthDate", "Email", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[] { new Guid("7ea1fce4-7ccc-4994-8c04-d8b411385aec"), "123 Main St", new DateTimeOffset(new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "john.doe@example.com", "John", 0, "Doe", "123-456-7890" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guests",
                keyColumn: "Id",
                keyValue: new Guid("7ea1fce4-7ccc-4994-8c04-d8b411385aec"));
        }
    }
}
