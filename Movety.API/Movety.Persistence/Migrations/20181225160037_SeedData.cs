using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movety.Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Created", "Latitude", "Longitude", "Modified" },
                values: new object[,]
                {
                    { new Guid("e577b7cd-da1f-4556-896b-789209378787"), null, new DateTime(2018, 12, 25, 17, 0, 37, 552, DateTimeKind.Local).AddTicks(8220), 51.107883000000001, 13.038538000000001, null },
                    { new Guid("ebcf2a90-e2e4-4104-bff0-575beb4b3c2f"), null, new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(4543), 57.107883000000001, 20.038537999999999, null },
                    { new Guid("12c29e27-24a3-4b5f-aad8-74c3858d7554"), null, new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(4617), 88.107883000000001, 40.038538000000003, null }
                });

            migrationBuilder.InsertData(
                table: "SportFields",
                columns: new[] { "Id", "Created", "Modified", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(6123), null, "cycling" },
                    { 2, new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(7226), null, "swimming" },
                    { 3, new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(7259), null, "climbing" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("12c29e27-24a3-4b5f-aad8-74c3858d7554"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e577b7cd-da1f-4556-896b-789209378787"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("ebcf2a90-e2e4-4104-bff0-575beb4b3c2f"));

            migrationBuilder.DeleteData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
