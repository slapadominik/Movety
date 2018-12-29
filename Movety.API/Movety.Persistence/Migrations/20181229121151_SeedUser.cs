using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movety.Persistence.Migrations
{
    public partial class SeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("6c87fced-e815-4c49-bb4b-8b250731a575"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("8a34998d-6e11-4ea6-8853-e8fa484b94c1"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("ae5331bc-46d4-4b96-b7ff-a57c313539c5"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("2709b89c-4cd0-4037-a1e9-481864e5b603"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("2b6bae7d-ab5e-4253-b8dd-3569031da4ae"));

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"), new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"), new Guid("3a002149-7a55-4b81-943f-d497a606cc77") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"), new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"), new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"), new Guid("3a002149-7a55-4b81-943f-d497a606cc77") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"), new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266") });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e77a53ba-5e77-4836-9f49-dd49b82a40b1"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3a002149-7a55-4b81-943f-d497a606cc77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("98285577-8523-45fd-b90b-6c0f8fa786b6"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d4512864-0a1b-4a34-92b1-e8d1447f9466"));

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Created", "Latitude", "Longitude", "Modified" },
                values: new object[,]
                {
                    { new Guid("1efc45d5-e79b-40d5-9b85-82cb76143737"), null, new DateTime(2018, 12, 29, 13, 11, 50, 840, DateTimeKind.Local).AddTicks(8901), 50.102074999999999, 18.509135000000001, null },
                    { new Guid("cd056011-4267-4b38-9666-0116123cb563"), null, new DateTime(2018, 12, 29, 13, 11, 50, 842, DateTimeKind.Local).AddTicks(6398), 50.094844999999999, 18.519753000000001, null },
                    { new Guid("b90f325f-2bad-47f0-8124-4c3235754bbf"), null, new DateTime(2018, 12, 29, 13, 11, 50, 842, DateTimeKind.Local).AddTicks(6509), 88.107883000000001, 40.038538000000003, null },
                    { new Guid("778320cc-8aaa-4460-9465-977346985be0"), null, new DateTime(2018, 12, 29, 13, 11, 50, 842, DateTimeKind.Local).AddTicks(6525), 51.114697, 17.046592, null }
                });

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 29, 13, 11, 50, 842, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 29, 13, 11, 50, 842, DateTimeKind.Local).AddTicks(9697));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 29, 13, 11, 50, 842, DateTimeKind.Local).AddTicks(9734));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 29, 13, 11, 50, 842, DateTimeKind.Local).AddTicks(9751));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Modified", "PasswordHash", "SecurityStamp", "Username" },
                values: new object[,]
                {
                    { new Guid("7d46d491-2166-451e-beaf-a57bb10cb91c"), new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(4600), "jankowalski@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" },
                    { new Guid("99dbdda5-86d0-422a-b1b7-3d1f7719e446"), new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(6713), "kamilszybki@gmail.com", null, "asdasdasd123213", "asd123", "kamil91" },
                    { new Guid("b7d2a6c1-2ba1-4aa0-83ea-ffa0434f66c5"), new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(6758), "jankowalski2@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" },
                    { new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10"), new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(6774), "jankowalski2@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan2" }
                });

            migrationBuilder.InsertData(
                table: "Athlethes",
                columns: new[] { "Id", "Birthdate", "Created", "Description", "FirstName", "Gender", "LastName", "Modified", "UserId" },
                values: new object[,]
                {
                    { new Guid("df73185c-e294-468e-8e8d-36c40b404736"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(7837), "Moje zainteresowania to....", "Jan", "m", "Kowalski", null, new Guid("7d46d491-2166-451e-beaf-a57bb10cb91c") },
                    { new Guid("4e2ae5fb-6dac-4b93-b0ee-63df0f413976"), new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 13, 11, 50, 844, DateTimeKind.Local).AddTicks(278), "Narty, siatkowka, koszykowka - sport.", "Ania", "m", "Boruc", null, new Guid("99dbdda5-86d0-422a-b1b7-3d1f7719e446") },
                    { new Guid("2922dd1a-e768-41df-98ff-c827c4b64d46"), new DateTime(1989, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 13, 11, 50, 844, DateTimeKind.Local).AddTicks(327), "Narty, siatkowka, koszykowka - sport.", "Wojciech", "m", "Nowak", null, new Guid("b7d2a6c1-2ba1-4aa0-83ea-ffa0434f66c5") },
                    { new Guid("7c41511c-a39b-4225-8f4c-c00409adffb6"), new DateTime(1993, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 13, 11, 50, 844, DateTimeKind.Local).AddTicks(347), "Narty, siatkowka, koszykowka - sport.", "Damian", "m", "Nowak", null, new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10") }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "Author", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId", "Title" },
                values: new object[,]
                {
                    { new Guid("ae30c6a1-4da8-424a-918a-17b6e0e7d754"), "Jan Kowalski", new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(1170), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum", new Guid("1efc45d5-e79b-40d5-9b85-82cb76143737"), 4, null, 1, "Rower we Wro!" },
                    { new Guid("a6645f56-0316-43a7-aa41-64f7ee58eaf1"), "Kamil Jacewicz", new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(3939), new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum2", new Guid("cd056011-4267-4b38-9666-0116123cb563"), 5, null, 2, "Wspinaczka na Tarnogaju" },
                    { new Guid("4a4066b8-402d-46cc-b167-7d02aa426689"), "Anna Kowalska", new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(3997), new DateTime(2019, 4, 12, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 12, 17, 20, 0, 0, DateTimeKind.Unspecified), "Zapraszam wszystkich na łyżwy na godzinę 19:30. ", new Guid("778320cc-8aaa-4460-9465-977346985be0"), 10, null, 4, "Łyżwy w Pszowie" }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposalsLikes",
                columns: new[] { "TrainingProposalsId", "UserId", "Created", "Modified" },
                values: new object[,]
                {
                    { new Guid("ae30c6a1-4da8-424a-918a-17b6e0e7d754"), new Guid("7d46d491-2166-451e-beaf-a57bb10cb91c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ae30c6a1-4da8-424a-918a-17b6e0e7d754"), new Guid("99dbdda5-86d0-422a-b1b7-3d1f7719e446"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ae30c6a1-4da8-424a-918a-17b6e0e7d754"), new Guid("b7d2a6c1-2ba1-4aa0-83ea-ffa0434f66c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a6645f56-0316-43a7-aa41-64f7ee58eaf1"), new Guid("7d46d491-2166-451e-beaf-a57bb10cb91c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a6645f56-0316-43a7-aa41-64f7ee58eaf1"), new Guid("99dbdda5-86d0-422a-b1b7-3d1f7719e446"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a6645f56-0316-43a7-aa41-64f7ee58eaf1"), new Guid("b7d2a6c1-2ba1-4aa0-83ea-ffa0434f66c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("2922dd1a-e768-41df-98ff-c827c4b64d46"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("4e2ae5fb-6dac-4b93-b0ee-63df0f413976"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("7c41511c-a39b-4225-8f4c-c00409adffb6"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("df73185c-e294-468e-8e8d-36c40b404736"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("b90f325f-2bad-47f0-8124-4c3235754bbf"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("4a4066b8-402d-46cc-b167-7d02aa426689"));

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("a6645f56-0316-43a7-aa41-64f7ee58eaf1"), new Guid("7d46d491-2166-451e-beaf-a57bb10cb91c") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("a6645f56-0316-43a7-aa41-64f7ee58eaf1"), new Guid("99dbdda5-86d0-422a-b1b7-3d1f7719e446") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("a6645f56-0316-43a7-aa41-64f7ee58eaf1"), new Guid("b7d2a6c1-2ba1-4aa0-83ea-ffa0434f66c5") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("ae30c6a1-4da8-424a-918a-17b6e0e7d754"), new Guid("7d46d491-2166-451e-beaf-a57bb10cb91c") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("ae30c6a1-4da8-424a-918a-17b6e0e7d754"), new Guid("99dbdda5-86d0-422a-b1b7-3d1f7719e446") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("ae30c6a1-4da8-424a-918a-17b6e0e7d754"), new Guid("b7d2a6c1-2ba1-4aa0-83ea-ffa0434f66c5") });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("778320cc-8aaa-4460-9465-977346985be0"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("a6645f56-0316-43a7-aa41-64f7ee58eaf1"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("ae30c6a1-4da8-424a-918a-17b6e0e7d754"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7d46d491-2166-451e-beaf-a57bb10cb91c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("99dbdda5-86d0-422a-b1b7-3d1f7719e446"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b7d2a6c1-2ba1-4aa0-83ea-ffa0434f66c5"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("1efc45d5-e79b-40d5-9b85-82cb76143737"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("cd056011-4267-4b38-9666-0116123cb563"));

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Created", "Latitude", "Longitude", "Modified" },
                values: new object[,]
                {
                    { new Guid("98285577-8523-45fd-b90b-6c0f8fa786b6"), null, new DateTime(2018, 12, 29, 11, 58, 18, 800, DateTimeKind.Local).AddTicks(4680), 50.102074999999999, 18.509135000000001, null },
                    { new Guid("d4512864-0a1b-4a34-92b1-e8d1447f9466"), null, new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(589), 50.094844999999999, 18.519753000000001, null },
                    { new Guid("2709b89c-4cd0-4037-a1e9-481864e5b603"), null, new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(684), 88.107883000000001, 40.038538000000003, null },
                    { new Guid("e77a53ba-5e77-4836-9f49-dd49b82a40b1"), null, new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(704), 51.114697, 17.046592, null }
                });

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(3626));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Modified", "PasswordHash", "SecurityStamp", "Username" },
                values: new object[,]
                {
                    { new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49"), new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(8204), "jankowalski@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" },
                    { new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266"), new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(9878), "kamilszybki@gmail.com", null, "asdasdasd123213", "asd123", "kamil91" },
                    { new Guid("3a002149-7a55-4b81-943f-d497a606cc77"), new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(9915), "jankowalski2@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" }
                });

            migrationBuilder.InsertData(
                table: "Athlethes",
                columns: new[] { "Id", "Birthdate", "Created", "Description", "FirstName", "Gender", "LastName", "Modified", "UserId" },
                values: new object[,]
                {
                    { new Guid("8a34998d-6e11-4ea6-8853-e8fa484b94c1"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 11, 58, 18, 803, DateTimeKind.Local).AddTicks(879), "Moje zainteresowania to....", "Jan", null, "Kowalski", null, new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49") },
                    { new Guid("ae5331bc-46d4-4b96-b7ff-a57c313539c5"), new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 11, 58, 18, 803, DateTimeKind.Local).AddTicks(3111), "Narty, siatkowka, koszykowka - sport.", "Ania", null, "Boruc", null, new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266") },
                    { new Guid("6c87fced-e815-4c49-bb4b-8b250731a575"), new DateTime(1989, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 11, 58, 18, 803, DateTimeKind.Local).AddTicks(3156), "Narty, siatkowka, koszykowka - sport.", "Wojciech", null, "Nowak", null, new Guid("3a002149-7a55-4b81-943f-d497a606cc77") }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "Author", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId", "Title" },
                values: new object[,]
                {
                    { new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"), "Jan Kowalski", new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(5021), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum", new Guid("98285577-8523-45fd-b90b-6c0f8fa786b6"), 4, null, 1, "Rower we Wro!" },
                    { new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"), "Kamil Jacewicz", new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(7601), new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum2", new Guid("d4512864-0a1b-4a34-92b1-e8d1447f9466"), 5, null, 2, "Wspinaczka na Tarnogaju" },
                    { new Guid("2b6bae7d-ab5e-4253-b8dd-3569031da4ae"), "Anna Kowalska", new DateTime(2018, 12, 29, 11, 58, 18, 802, DateTimeKind.Local).AddTicks(7655), new DateTime(2019, 4, 12, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 12, 17, 20, 0, 0, DateTimeKind.Unspecified), "Zapraszam wszystkich na łyżwy na godzinę 19:30. ", new Guid("e77a53ba-5e77-4836-9f49-dd49b82a40b1"), 10, null, 4, "Łyżwy w Pszowie" }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposalsLikes",
                columns: new[] { "TrainingProposalsId", "UserId", "Created", "Modified" },
                values: new object[,]
                {
                    { new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"), new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"), new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("2e42a82a-d3c6-43b0-9778-f7e20bdcad5d"), new Guid("3a002149-7a55-4b81-943f-d497a606cc77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"), new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"), new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("2aa308fe-aaf2-4d8e-8c51-3f4fece260fb"), new Guid("3a002149-7a55-4b81-943f-d497a606cc77"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
