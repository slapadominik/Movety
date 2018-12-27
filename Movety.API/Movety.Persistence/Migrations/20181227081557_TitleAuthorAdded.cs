using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movety.Persistence.Migrations
{
    public partial class TitleAuthorAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "TrainingProposals",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "TrainingProposals",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Created", "Latitude", "Longitude", "Modified" },
                values: new object[,]
                {
                    { new Guid("bb60de0b-ce0b-4f9b-9bd1-e2320b9779dc"), null, new DateTime(2018, 12, 27, 9, 15, 56, 870, DateTimeKind.Local).AddTicks(1653), 51.107883000000001, 13.038538000000001, null },
                    { new Guid("3f992909-8635-485f-be3c-e3f1cb6e951e"), null, new DateTime(2018, 12, 27, 9, 15, 56, 871, DateTimeKind.Local).AddTicks(7694), 57.107883000000001, 20.038537999999999, null },
                    { new Guid("686c0a8c-f98f-4910-b839-d0fa038725bc"), null, new DateTime(2018, 12, 27, 9, 15, 56, 871, DateTimeKind.Local).AddTicks(7784), 88.107883000000001, 40.038538000000003, null }
                });

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 27, 9, 15, 56, 871, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 27, 9, 15, 56, 872, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 27, 9, 15, 56, 872, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "Author", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId", "Title" },
                values: new object[] { new Guid("e34b2b91-33fe-40da-b856-c05801896062"), "Jan Kowalski", new DateTime(2018, 12, 27, 9, 15, 56, 872, DateTimeKind.Local).AddTicks(1870), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum", new Guid("bb60de0b-ce0b-4f9b-9bd1-e2320b9779dc"), 4, null, 1, "Rower we Wro!" });

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "Author", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId", "Title" },
                values: new object[] { new Guid("317d07d0-9d2b-4a9e-9284-facc42ff2736"), "Kamil Jacewicz", new DateTime(2018, 12, 27, 9, 15, 56, 872, DateTimeKind.Local).AddTicks(4652), new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum2", new Guid("3f992909-8635-485f-be3c-e3f1cb6e951e"), 5, null, 2, "Wspinaczka na Tarnogaju" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("686c0a8c-f98f-4910-b839-d0fa038725bc"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("317d07d0-9d2b-4a9e-9284-facc42ff2736"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("e34b2b91-33fe-40da-b856-c05801896062"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("3f992909-8635-485f-be3c-e3f1cb6e951e"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("bb60de0b-ce0b-4f9b-9bd1-e2320b9779dc"));

            migrationBuilder.DropColumn(
                name: "Author",
                table: "TrainingProposals");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "TrainingProposals");

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
    }
}
