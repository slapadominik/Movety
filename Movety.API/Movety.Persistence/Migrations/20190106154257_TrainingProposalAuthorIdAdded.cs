using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movety.Persistence.Migrations
{
    public partial class TrainingProposalAuthorIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Author",
                table: "TrainingProposals");

            migrationBuilder.AddColumn<Guid>(
                name: "AuthorId",
                table: "TrainingProposals",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Athlethes",
                columns: new[] { "Id", "Birthdate", "Created", "Description", "FirstName", "Gender", "LastName", "Modified", "UserId" },
                values: new object[] { new Guid("a0ffa806-c3fa-4f45-8147-7f9c6331c2f9"), new DateTime(1993, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(1671), "Narty, siatkowka, koszykowka - sport.", "Damian", "m", "Nowak", null, new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10") });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "City", "Created", "Latitude", "Longitude", "Modified" },
                values: new object[,]
                {
                    { new Guid("37d767e0-4c4b-44b0-809d-8ae89235f5fb"), null, new DateTime(2019, 1, 6, 16, 42, 57, 520, DateTimeKind.Local).AddTicks(3949), 50.102074999999999, 18.509135000000001, null },
                    { new Guid("26bd2c52-f77d-419a-81a6-ed6e65992536"), null, new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1176), 50.094844999999999, 18.519753000000001, null },
                    { new Guid("f7bf4ad4-530f-43b0-bfb4-fcc99bc97ebf"), null, new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1275), 88.107883000000001, 40.038538000000003, null },
                    { new Guid("80b4ed41-79ef-433b-97cc-ded5bec5f174"), null, new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1345), 51.114697, 17.046592, null },
                    { new Guid("0c2c96f5-1a13-4526-a505-201387307d7a"), null, new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1365), 51.087727000000001, 17.032025999999998, null },
                    { new Guid("9e9bf630-d669-4cf0-b242-a1d5ea2a2441"), null, new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1386), 51.091599000000002, 17.019652000000001, null },
                    { new Guid("d7a4da39-aae0-4979-a89d-4623936d9349"), null, new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(1402), 51.113126000000001, 17.069683000000001, null }
                });

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(5254));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10"),
                column: "Created",
                value: new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Modified", "PasswordHash", "SecurityStamp", "Username" },
                values: new object[,]
                {
                    { new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c"), new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(6137), "jankowalski@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" },
                    { new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375"), new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(8122), "kamilszybki@gmail.com", null, "asdasdasd123213", "asd123", "kamil91" },
                    { new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b"), new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(8163), "jankowalski2@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" }
                });

            migrationBuilder.InsertData(
                table: "Athlethes",
                columns: new[] { "Id", "Birthdate", "Created", "Description", "FirstName", "Gender", "LastName", "Modified", "UserId" },
                values: new object[,]
                {
                    { new Guid("1231b8b0-f42b-4440-912b-f108fc1d7e5e"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 6, 16, 42, 57, 522, DateTimeKind.Local).AddTicks(9361), "Moje zainteresowania to....", "Jan", "m", "Kowalski", null, new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c") },
                    { new Guid("92a068dc-8842-4bf4-9dcd-5dbcfc42f719"), new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(1589), "Narty, siatkowka, koszykowka - sport.", "Ania", "m", "Boruc", null, new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375") },
                    { new Guid("72ab8ea9-f8c8-4767-806f-99d728d37714"), new DateTime(1989, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(1638), "Narty, siatkowka, koszykowka - sport.", "Wojciech", "m", "Nowak", null, new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b") }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "AuthorId", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId", "Title" },
                values: new object[,]
                {
                    { new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"), new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10"), new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(8481), new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum2", new Guid("9e9bf630-d669-4cf0-b242-a1d5ea2a2441"), 5, null, 2, "Wspinaczka na Tarnogaju" },
                    { new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"), new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10"), new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(5773), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum", new Guid("d7a4da39-aae0-4979-a89d-4623936d9349"), 4, null, 1, "Rower we Wro!" },
                    { new Guid("1595b442-49b7-4548-98da-8ef656d733fb"), new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c"), new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(8543), new DateTime(2019, 4, 12, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 12, 17, 20, 0, 0, DateTimeKind.Unspecified), "Zapraszam wszystkich na łyżwy na godzinę 19:30. ", new Guid("80b4ed41-79ef-433b-97cc-ded5bec5f174"), 10, null, 4, "Łyżwy w Pszowie" },
                    { new Guid("4fd3bbd8-7644-4984-9226-e185bb52839c"), new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375"), new DateTime(2019, 1, 6, 16, 42, 57, 523, DateTimeKind.Local).AddTicks(8567), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum", new Guid("0c2c96f5-1a13-4526-a505-201387307d7a"), 6, null, 1, "Rolki na rampie" }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposalsLikes",
                columns: new[] { "TrainingProposalsId", "UserId", "Created", "Modified" },
                values: new object[,]
                {
                    { new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"), new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"), new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"), new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"), new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"), new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"), new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingProposals_AuthorId",
                table: "TrainingProposals",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TrainingProposals_Users_AuthorId",
                table: "TrainingProposals",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TrainingProposals_Users_AuthorId",
                table: "TrainingProposals");

            migrationBuilder.DropIndex(
                name: "IX_TrainingProposals_AuthorId",
                table: "TrainingProposals");

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("1231b8b0-f42b-4440-912b-f108fc1d7e5e"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("72ab8ea9-f8c8-4767-806f-99d728d37714"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("92a068dc-8842-4bf4-9dcd-5dbcfc42f719"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("a0ffa806-c3fa-4f45-8147-7f9c6331c2f9"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("26bd2c52-f77d-419a-81a6-ed6e65992536"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("37d767e0-4c4b-44b0-809d-8ae89235f5fb"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("f7bf4ad4-530f-43b0-bfb4-fcc99bc97ebf"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("1595b442-49b7-4548-98da-8ef656d733fb"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("4fd3bbd8-7644-4984-9226-e185bb52839c"));

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"), new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"), new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"), new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"), new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"), new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"), new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375") });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("0c2c96f5-1a13-4526-a505-201387307d7a"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("80b4ed41-79ef-433b-97cc-ded5bec5f174"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("07655066-e50c-425f-8e9a-5fa60e4c5617"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("33b4dd13-49d3-40a2-a933-13d338bc6704"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1773ae03-8d33-4a00-a193-17ade5132f1c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("40dd14dc-42ec-4a60-806a-90d02a3e104b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8256aebe-2be8-4de4-9bd0-f87c0ba11375"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9e9bf630-d669-4cf0-b242-a1d5ea2a2441"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d7a4da39-aae0-4979-a89d-4623936d9349"));

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "TrainingProposals");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "TrainingProposals",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Athlethes",
                columns: new[] { "Id", "Birthdate", "Created", "Description", "FirstName", "Gender", "LastName", "Modified", "UserId" },
                values: new object[] { new Guid("7c41511c-a39b-4225-8f4c-c00409adffb6"), new DateTime(1993, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 13, 11, 50, 844, DateTimeKind.Local).AddTicks(347), "Narty, siatkowka, koszykowka - sport.", "Damian", null, "Nowak", null, new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10") });

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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("38e88f51-a4bd-4163-be6e-cdaad099ba10"),
                column: "Created",
                value: new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(6774));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Modified", "PasswordHash", "SecurityStamp", "Username" },
                values: new object[,]
                {
                    { new Guid("7d46d491-2166-451e-beaf-a57bb10cb91c"), new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(4600), "jankowalski@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" },
                    { new Guid("99dbdda5-86d0-422a-b1b7-3d1f7719e446"), new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(6713), "kamilszybki@gmail.com", null, "asdasdasd123213", "asd123", "kamil91" },
                    { new Guid("b7d2a6c1-2ba1-4aa0-83ea-ffa0434f66c5"), new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(6758), "jankowalski2@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" }
                });

            migrationBuilder.InsertData(
                table: "Athlethes",
                columns: new[] { "Id", "Birthdate", "Created", "Description", "FirstName", "Gender", "LastName", "Modified", "UserId" },
                values: new object[,]
                {
                    { new Guid("df73185c-e294-468e-8e8d-36c40b404736"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 13, 11, 50, 843, DateTimeKind.Local).AddTicks(7837), "Moje zainteresowania to....", "Jan", null, "Kowalski", null, new Guid("7d46d491-2166-451e-beaf-a57bb10cb91c") },
                    { new Guid("4e2ae5fb-6dac-4b93-b0ee-63df0f413976"), new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 13, 11, 50, 844, DateTimeKind.Local).AddTicks(278), "Narty, siatkowka, koszykowka - sport.", "Ania", null, "Boruc", null, new Guid("99dbdda5-86d0-422a-b1b7-3d1f7719e446") },
                    { new Guid("2922dd1a-e768-41df-98ff-c827c4b64d46"), new DateTime(1989, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 13, 11, 50, 844, DateTimeKind.Local).AddTicks(327), "Narty, siatkowka, koszykowka - sport.", "Wojciech", null, "Nowak", null, new Guid("b7d2a6c1-2ba1-4aa0-83ea-ffa0434f66c5") }
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
    }
}
