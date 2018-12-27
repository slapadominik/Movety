using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movety.Persistence.Migrations
{
    public partial class SeedDataTrainingProposals : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Created", "Latitude", "Longitude", "Modified" },
                values: new object[,]
                {
                    { new Guid("f155a8b0-6a05-4587-a9f0-bbbd7f67ab36"), null, new DateTime(2018, 12, 26, 11, 27, 8, 310, DateTimeKind.Local).AddTicks(414), 51.107883000000001, 13.038538000000001, null },
                    { new Guid("e0a7a518-d626-4948-9ef3-efb7070b52c9"), null, new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(5839), 57.107883000000001, 20.038537999999999, null },
                    { new Guid("08747727-f75f-4656-a4dc-f7640a8b53e0"), null, new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(5930), 88.107883000000001, 40.038538000000003, null }
                });

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId" },
                values: new object[] { new Guid("20519637-f600-461a-b8da-1766481e0538"), new DateTime(2018, 12, 26, 11, 27, 8, 311, DateTimeKind.Local).AddTicks(9080), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum", new Guid("f155a8b0-6a05-4587-a9f0-bbbd7f67ab36"), 4, null, 1 });

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId" },
                values: new object[] { new Guid("dc0e3dd4-abda-4591-a29b-3bca6e9a6a9f"), new DateTime(2018, 12, 26, 11, 27, 8, 312, DateTimeKind.Local).AddTicks(1530), new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum2", new Guid("e0a7a518-d626-4948-9ef3-efb7070b52c9"), 5, null, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("08747727-f75f-4656-a4dc-f7640a8b53e0"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("20519637-f600-461a-b8da-1766481e0538"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("dc0e3dd4-abda-4591-a29b-3bca6e9a6a9f"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e0a7a518-d626-4948-9ef3-efb7070b52c9"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("f155a8b0-6a05-4587-a9f0-bbbd7f67ab36"));

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Created", "Latitude", "Longitude", "Modified" },
                values: new object[,]
                {
                    { new Guid("e577b7cd-da1f-4556-896b-789209378787"), null, new DateTime(2018, 12, 25, 17, 0, 37, 552, DateTimeKind.Local).AddTicks(8220), 51.107883000000001, 13.038538000000001, null },
                    { new Guid("ebcf2a90-e2e4-4104-bff0-575beb4b3c2f"), null, new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(4543), 57.107883000000001, 20.038537999999999, null },
                    { new Guid("12c29e27-24a3-4b5f-aad8-74c3858d7554"), null, new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(4617), 88.107883000000001, 40.038538000000003, null }
                });

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 25, 17, 0, 37, 554, DateTimeKind.Local).AddTicks(7259));
        }
    }
}
