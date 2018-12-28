using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movety.Persistence.Migrations
{
    public partial class SeedLikes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("189072d0-7995-4395-a4d9-fcd4b9dd2030"));

            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("34bbf782-51d4-4828-872c-1ff0a9d880dd"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("9c8e7a41-0ab2-4e0a-ae41-a57a83e8c8f1"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("775fde61-ee34-4fe5-92e7-205f97b088e1"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("a53a82ed-e50c-4df7-a1be-e6ff48d57bc5"));

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("14656c7f-2efd-44e8-9494-2bd0612e76aa"), new Guid("1b60d32b-cdb9-49f9-bca9-90d77973262a") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("14656c7f-2efd-44e8-9494-2bd0612e76aa"), new Guid("4395f693-67f3-4889-8374-a906855e5931") });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("52090ac2-2e46-40c0-aea3-47bd0e95f3db"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("a4003d93-ae33-43c6-beba-bb2e4d8fab3b"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("14656c7f-2efd-44e8-9494-2bd0612e76aa"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1b60d32b-cdb9-49f9-bca9-90d77973262a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4395f693-67f3-4889-8374-a906855e5931"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("277c64e0-7745-4fe7-a5a1-e09b6d42b25b"));

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
                    { new Guid("b1580a16-cb72-42e1-8773-9c6718860c1a"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(6612), "Moje zainteresowania to....", "Jan", "m", "Kowalski", null, new Guid("6056a1f9-d095-4f3e-ad0f-6aad0b03c16e") },
                    { new Guid("0b13b989-1c12-451f-8037-bb054237494b"), new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(8819), "Narty, siatkowka, koszykowka - sport.", "Ania", "m", "Boruc", null, new Guid("58c390b9-a6d4-4ac0-8e70-4a5d4efd0a78") },
                    { new Guid("7aa8941c-a1d2-438c-8890-29e5cbee6b1d"), new DateTime(1989, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 35, 43, 638, DateTimeKind.Local).AddTicks(8860), "Narty, siatkowka, koszykowka - sport.", "Wojciech", "m", "Nowak", null, new Guid("9e01965e-b696-41e6-9337-aeb58f4fc14f") }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("277c64e0-7745-4fe7-a5a1-e09b6d42b25b"), null, new DateTime(2018, 12, 28, 20, 20, 29, 365, DateTimeKind.Local).AddTicks(7653), 51.107883000000001, 13.038538000000001, null },
                    { new Guid("a4003d93-ae33-43c6-beba-bb2e4d8fab3b"), null, new DateTime(2018, 12, 28, 20, 20, 29, 367, DateTimeKind.Local).AddTicks(4080), 57.107883000000001, 20.038537999999999, null },
                    { new Guid("9c8e7a41-0ab2-4e0a-ae41-a57a83e8c8f1"), null, new DateTime(2018, 12, 28, 20, 20, 29, 367, DateTimeKind.Local).AddTicks(4178), 88.107883000000001, 40.038538000000003, null },
                    { new Guid("52090ac2-2e46-40c0-aea3-47bd0e95f3db"), null, new DateTime(2018, 12, 28, 20, 20, 29, 367, DateTimeKind.Local).AddTicks(4199), 54.107883000000001, 12.038538000000001, null }
                });

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 28, 20, 20, 29, 367, DateTimeKind.Local).AddTicks(5959));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 28, 20, 20, 29, 367, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 28, 20, 20, 29, 367, DateTimeKind.Local).AddTicks(7296));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 28, 20, 20, 29, 367, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Modified", "PasswordHash", "SecurityStamp", "Username" },
                values: new object[,]
                {
                    { new Guid("4395f693-67f3-4889-8374-a906855e5931"), new DateTime(2018, 12, 28, 20, 20, 29, 368, DateTimeKind.Local).AddTicks(2420), "jankowalski@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" },
                    { new Guid("1b60d32b-cdb9-49f9-bca9-90d77973262a"), new DateTime(2018, 12, 28, 20, 20, 29, 368, DateTimeKind.Local).AddTicks(4262), "kamilszybki@gmail.com", null, "asdasdasd123213", "asd123", "kamil91" }
                });

            migrationBuilder.InsertData(
                table: "Athlethes",
                columns: new[] { "Id", "Birthdate", "Created", "Description", "FirstName", "Gender", "LastName", "Modified", "UserId" },
                values: new object[,]
                {
                    { new Guid("189072d0-7995-4395-a4d9-fcd4b9dd2030"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 20, 29, 368, DateTimeKind.Local).AddTicks(5320), "Moje zainteresowania to....", "Jan", null, "Kowalski", null, new Guid("4395f693-67f3-4889-8374-a906855e5931") },
                    { new Guid("34bbf782-51d4-4828-872c-1ff0a9d880dd"), new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 20, 29, 368, DateTimeKind.Local).AddTicks(7581), "Narty, siatkowka, koszykowka - sport.", "Ania", null, "Boruc", null, new Guid("1b60d32b-cdb9-49f9-bca9-90d77973262a") }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "Author", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId", "Title" },
                values: new object[,]
                {
                    { new Guid("14656c7f-2efd-44e8-9494-2bd0612e76aa"), "Jan Kowalski", new DateTime(2018, 12, 28, 20, 20, 29, 367, DateTimeKind.Local).AddTicks(8794), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum", new Guid("277c64e0-7745-4fe7-a5a1-e09b6d42b25b"), 4, null, 1, "Rower we Wro!" },
                    { new Guid("a53a82ed-e50c-4df7-a1be-e6ff48d57bc5"), "Kamil Jacewicz", new DateTime(2018, 12, 28, 20, 20, 29, 368, DateTimeKind.Local).AddTicks(1784), new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum2", new Guid("a4003d93-ae33-43c6-beba-bb2e4d8fab3b"), 5, null, 2, "Wspinaczka na Tarnogaju" },
                    { new Guid("775fde61-ee34-4fe5-92e7-205f97b088e1"), "Anna Kowalska", new DateTime(2018, 12, 28, 20, 20, 29, 368, DateTimeKind.Local).AddTicks(1833), new DateTime(2019, 4, 12, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 12, 17, 20, 0, 0, DateTimeKind.Unspecified), "Zapraszam wszystkich na łyżwy na godzinę 19:30. ", new Guid("52090ac2-2e46-40c0-aea3-47bd0e95f3db"), 10, null, 4, "Łyżwy w Pszowie" }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposalsLikes",
                columns: new[] { "TrainingProposalsId", "UserId", "Created", "Modified" },
                values: new object[] { new Guid("14656c7f-2efd-44e8-9494-2bd0612e76aa"), new Guid("4395f693-67f3-4889-8374-a906855e5931"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TrainingProposalsLikes",
                columns: new[] { "TrainingProposalsId", "UserId", "Created", "Modified" },
                values: new object[] { new Guid("14656c7f-2efd-44e8-9494-2bd0612e76aa"), new Guid("1b60d32b-cdb9-49f9-bca9-90d77973262a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
