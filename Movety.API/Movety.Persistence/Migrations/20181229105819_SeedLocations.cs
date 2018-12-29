using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movety.Persistence.Migrations
{
    public partial class SeedLocations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("0b13b989-1c12-451f-8037-bb054237494b"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("7aa8941c-a1d2-438c-8890-29e5cbee6b1d"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("b1580a16-cb72-42e1-8773-9c6718860c1a"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("34f5e9fe-aa0a-44fe-81c0-3f1734454c20"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("5e408190-29e5-448d-83ec-2df8e86e8ecd"));

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("35a77813-8041-45e2-9673-ded45ab24ee8"), new Guid("58c390b9-a6d4-4ac0-8e70-4a5d4efd0a78") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("35a77813-8041-45e2-9673-ded45ab24ee8"), new Guid("6056a1f9-d095-4f3e-ad0f-6aad0b03c16e") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("35a77813-8041-45e2-9673-ded45ab24ee8"), new Guid("9e01965e-b696-41e6-9337-aeb58f4fc14f") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("b6f43ba8-3978-432d-be1d-e519402d6e51"), new Guid("58c390b9-a6d4-4ac0-8e70-4a5d4efd0a78") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("b6f43ba8-3978-432d-be1d-e519402d6e51"), new Guid("6056a1f9-d095-4f3e-ad0f-6aad0b03c16e") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("b6f43ba8-3978-432d-be1d-e519402d6e51"), new Guid("9e01965e-b696-41e6-9337-aeb58f4fc14f") });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("d88d60c9-cbb3-473b-ac43-c69991fea8e2"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("35a77813-8041-45e2-9673-ded45ab24ee8"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("b6f43ba8-3978-432d-be1d-e519402d6e51"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("58c390b9-a6d4-4ac0-8e70-4a5d4efd0a78"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6056a1f9-d095-4f3e-ad0f-6aad0b03c16e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9e01965e-b696-41e6-9337-aeb58f4fc14f"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("12e06bc7-5094-4bb2-a3c1-a9b884730ef1"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("5ba81a11-2ef6-456e-8d20-f1490bbbb4dd"));

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
                    { new Guid("8a34998d-6e11-4ea6-8853-e8fa484b94c1"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 11, 58, 18, 803, DateTimeKind.Local).AddTicks(879), "Moje zainteresowania to....", "Jan", "m", "Kowalski", null, new Guid("1bf5a1af-ed72-45f3-ac36-03bdc7baaa49") },
                    { new Guid("ae5331bc-46d4-4b96-b7ff-a57c313539c5"), new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 11, 58, 18, 803, DateTimeKind.Local).AddTicks(3111), "Narty, siatkowka, koszykowka - sport.", "Ania", "m", "Boruc", null, new Guid("b8e23deb-fcbd-4988-b3f0-5e6925d36266") },
                    { new Guid("6c87fced-e815-4c49-bb4b-8b250731a575"), new DateTime(1989, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 29, 11, 58, 18, 803, DateTimeKind.Local).AddTicks(3156), "Narty, siatkowka, koszykowka - sport.", "Wojciech", "m", "Nowak", null, new Guid("3a002149-7a55-4b81-943f-d497a606cc77") }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("12e06bc7-5094-4bb2-a3c1-a9b884730ef1"), null, new DateTime(2018, 12, 28, 20, 35, 43, 636, DateTimeKind.Local).AddTicks(495), 51.107883000000001, 13.038538000000001, null },
                    { new Guid("5ba81a11-2ef6-456e-8d20-f1490bbbb4dd"), null, new DateTime(2018, 12, 28, 20, 35, 43, 637, DateTimeKind.Local).AddTicks(6364), 57.107883000000001, 20.038537999999999, null },
                    { new Guid("34f5e9fe-aa0a-44fe-81c0-3f1734454c20"), null, new DateTime(2018, 12, 28, 20, 35, 43, 637, DateTimeKind.Local).AddTicks(6454), 88.107883000000001, 40.038538000000003, null },
                    { new Guid("d88d60c9-cbb3-473b-ac43-c69991fea8e2"), null, new DateTime(2018, 12, 28, 20, 35, 43, 637, DateTimeKind.Local).AddTicks(6470), 54.107883000000001, 12.038538000000001, null }
                });

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 28, 20, 35, 43, 637, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 28, 20, 35, 43, 637, DateTimeKind.Local).AddTicks(9334));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 28, 20, 35, 43, 637, DateTimeKind.Local).AddTicks(9367));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 28, 20, 35, 43, 637, DateTimeKind.Local).AddTicks(9387));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Modified", "PasswordHash", "SecurityStamp", "Username" },
                values: new object[,]
                {
                    { new Guid("6056a1f9-d095-4f3e-ad0f-6aad0b03c16e"), new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(3929), "jankowalski@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" },
                    { new Guid("58c390b9-a6d4-4ac0-8e70-4a5d4efd0a78"), new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(5603), "kamilszybki@gmail.com", null, "asdasdasd123213", "asd123", "kamil91" },
                    { new Guid("9e01965e-b696-41e6-9337-aeb58f4fc14f"), new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(5640), "jankowalski2@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" }
                });

            migrationBuilder.InsertData(
                table: "Athlethes",
                columns: new[] { "Id", "Birthdate", "Created", "Description", "FirstName", "Gender", "LastName", "Modified", "UserId" },
                values: new object[,]
                {
                    { new Guid("b1580a16-cb72-42e1-8773-9c6718860c1a"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(6612), "Moje zainteresowania to....", "Jan", null, "Kowalski", null, new Guid("6056a1f9-d095-4f3e-ad0f-6aad0b03c16e") },
                    { new Guid("0b13b989-1c12-451f-8037-bb054237494b"), new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(8819), "Narty, siatkowka, koszykowka - sport.", "Ania", null, "Boruc", null, new Guid("58c390b9-a6d4-4ac0-8e70-4a5d4efd0a78") },
                    { new Guid("7aa8941c-a1d2-438c-8890-29e5cbee6b1d"), new DateTime(1989, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(8860), "Narty, siatkowka, koszykowka - sport.", "Wojciech", null, "Nowak", null, new Guid("9e01965e-b696-41e6-9337-aeb58f4fc14f") }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "Author", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId", "Title" },
                values: new object[,]
                {
                    { new Guid("b6f43ba8-3978-432d-be1d-e519402d6e51"), "Jan Kowalski", new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(716), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum", new Guid("12e06bc7-5094-4bb2-a3c1-a9b884730ef1"), 4, null, 1, "Rower we Wro!" },
                    { new Guid("35a77813-8041-45e2-9673-ded45ab24ee8"), "Kamil Jacewicz", new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(3317), new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum2", new Guid("5ba81a11-2ef6-456e-8d20-f1490bbbb4dd"), 5, null, 2, "Wspinaczka na Tarnogaju" },
                    { new Guid("5e408190-29e5-448d-83ec-2df8e86e8ecd"), "Anna Kowalska", new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(3379), new DateTime(2019, 4, 12, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 12, 17, 20, 0, 0, DateTimeKind.Unspecified), "Zapraszam wszystkich na łyżwy na godzinę 19:30. ", new Guid("d88d60c9-cbb3-473b-ac43-c69991fea8e2"), 10, null, 4, "Łyżwy w Pszowie" }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposalsLikes",
                columns: new[] { "TrainingProposalsId", "UserId", "Created", "Modified" },
                values: new object[,]
                {
                    { new Guid("b6f43ba8-3978-432d-be1d-e519402d6e51"), new Guid("6056a1f9-d095-4f3e-ad0f-6aad0b03c16e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b6f43ba8-3978-432d-be1d-e519402d6e51"), new Guid("58c390b9-a6d4-4ac0-8e70-4a5d4efd0a78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("b6f43ba8-3978-432d-be1d-e519402d6e51"), new Guid("9e01965e-b696-41e6-9337-aeb58f4fc14f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("35a77813-8041-45e2-9673-ded45ab24ee8"), new Guid("6056a1f9-d095-4f3e-ad0f-6aad0b03c16e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("35a77813-8041-45e2-9673-ded45ab24ee8"), new Guid("58c390b9-a6d4-4ac0-8e70-4a5d4efd0a78"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("35a77813-8041-45e2-9673-ded45ab24ee8"), new Guid("9e01965e-b696-41e6-9337-aeb58f4fc14f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });
        }
    }
}
