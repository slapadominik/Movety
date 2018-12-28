using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Movety.Persistence.Migrations
{
    public partial class AthletheUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Athlethes",
                keyColumn: "Id",
                keyValue: new Guid("67995fa7-a8ac-421f-89ee-cbff3345d139"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("7fc4d86b-0f2c-49d8-904e-0df5e376dbda"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("c0b1c7b6-695e-4dd1-ba35-b2110c918a88"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("ce89948b-5d56-431f-ab03-20f353d873d9"));

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("02f3ef91-2894-414d-adc2-c24a78400a12"), new Guid("3779b923-f7e2-4ba0-8f18-c7fcdc9f6eb0") });

            migrationBuilder.DeleteData(
                table: "TrainingProposalsLikes",
                keyColumns: new[] { "TrainingProposalsId", "UserId" },
                keyValues: new object[] { new Guid("02f3ef91-2894-414d-adc2-c24a78400a12"), new Guid("893a3823-2412-4d04-8f66-0f09cc52c788") });

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("bc0958fa-2898-4481-9502-1f8c09f2a95b"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("cd2ce8f4-5ae2-4e85-8c67-673f5549423a"));

            migrationBuilder.DeleteData(
                table: "TrainingProposals",
                keyColumn: "Id",
                keyValue: new Guid("02f3ef91-2894-414d-adc2-c24a78400a12"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3779b923-f7e2-4ba0-8f18-c7fcdc9f6eb0"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("893a3823-2412-4d04-8f66-0f09cc52c788"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e2cdd84c-7857-47a2-a0d1-69d8021486b0"));

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
                    { new Guid("189072d0-7995-4395-a4d9-fcd4b9dd2030"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 20, 29, 368, DateTimeKind.Local).AddTicks(5320), "Moje zainteresowania to....", "Jan", "m", "Kowalski", null, new Guid("4395f693-67f3-4889-8374-a906855e5931") },
                    { new Guid("34bbf782-51d4-4828-872c-1ff0a9d880dd"), new DateTime(1985, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 28, 20, 20, 29, 368, DateTimeKind.Local).AddTicks(7581), "Narty, siatkowka, koszykowka - sport.", "Ania", "m", "Boruc", null, new Guid("1b60d32b-cdb9-49f9-bca9-90d77973262a") }
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("e2cdd84c-7857-47a2-a0d1-69d8021486b0"), null, new DateTime(2018, 12, 27, 12, 5, 12, 740, DateTimeKind.Local).AddTicks(4865), 51.107883000000001, 13.038538000000001, null },
                    { new Guid("cd2ce8f4-5ae2-4e85-8c67-673f5549423a"), null, new DateTime(2018, 12, 27, 12, 5, 12, 742, DateTimeKind.Local).AddTicks(2666), 57.107883000000001, 20.038537999999999, null },
                    { new Guid("7fc4d86b-0f2c-49d8-904e-0df5e376dbda"), null, new DateTime(2018, 12, 27, 12, 5, 12, 742, DateTimeKind.Local).AddTicks(2765), 88.107883000000001, 40.038538000000003, null },
                    { new Guid("bc0958fa-2898-4481-9502-1f8c09f2a95b"), null, new DateTime(2018, 12, 27, 12, 5, 12, 742, DateTimeKind.Local).AddTicks(2785), 54.107883000000001, 12.038538000000001, null }
                });

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2018, 12, 27, 12, 5, 12, 742, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2018, 12, 27, 12, 5, 12, 742, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2018, 12, 27, 12, 5, 12, 742, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "SportFields",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2018, 12, 27, 12, 5, 12, 742, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Email", "Modified", "PasswordHash", "SecurityStamp", "Username" },
                values: new object[,]
                {
                    { new Guid("893a3823-2412-4d04-8f66-0f09cc52c788"), new DateTime(2018, 12, 27, 12, 5, 12, 743, DateTimeKind.Local).AddTicks(1064), "jankowalski@gmail.com", null, "asdasdasd123213", "asd123", "kowalskijan3" },
                    { new Guid("3779b923-f7e2-4ba0-8f18-c7fcdc9f6eb0"), new DateTime(2018, 12, 27, 12, 5, 12, 743, DateTimeKind.Local).AddTicks(2840), "kamilszybki@gmail.com", null, "asdasdasd123213", "asd123", "kamil91" }
                });

            migrationBuilder.InsertData(
                table: "Athlethes",
                columns: new[] { "Id", "Birthdate", "Created", "Description", "FirstName", "Gender", "LastName", "Modified", "UserId" },
                values: new object[] { new Guid("67995fa7-a8ac-421f-89ee-cbff3345d139"), new DateTime(2002, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 12, 27, 12, 5, 12, 743, DateTimeKind.Local).AddTicks(3854), "Moje zainteresowania to....", "Jan", null, "Kowalski", null, new Guid("893a3823-2412-4d04-8f66-0f09cc52c788") });

            migrationBuilder.InsertData(
                table: "TrainingProposals",
                columns: new[] { "Id", "Author", "Created", "DatetimeFrom", "DatetimeTo", "Description", "LocationId", "MaxParticipants", "Modified", "SportFieldId", "Title" },
                values: new object[,]
                {
                    { new Guid("02f3ef91-2894-414d-adc2-c24a78400a12"), "Jan Kowalski", new DateTime(2018, 12, 27, 12, 5, 12, 742, DateTimeKind.Local).AddTicks(7770), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 3, 8, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum", new Guid("e2cdd84c-7857-47a2-a0d1-69d8021486b0"), 4, null, 1, "Rower we Wro!" },
                    { new Guid("ce89948b-5d56-431f-ab03-20f353d873d9"), "Kamil Jacewicz", new DateTime(2018, 12, 27, 12, 5, 12, 743, DateTimeKind.Local).AddTicks(350), new DateTime(2020, 3, 5, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 17, 20, 0, 0, DateTimeKind.Unspecified), "Lorem ipsum lorem ipsum2", new Guid("cd2ce8f4-5ae2-4e85-8c67-673f5549423a"), 5, null, 2, "Wspinaczka na Tarnogaju" },
                    { new Guid("c0b1c7b6-695e-4dd1-ba35-b2110c918a88"), "Anna Kowalska", new DateTime(2018, 12, 27, 12, 5, 12, 743, DateTimeKind.Local).AddTicks(404), new DateTime(2019, 4, 12, 15, 20, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 12, 17, 20, 0, 0, DateTimeKind.Unspecified), "Zapraszam wszystkich na łyżwy na godzinę 19:30. ", new Guid("bc0958fa-2898-4481-9502-1f8c09f2a95b"), 10, null, 4, "Łyżwy w Pszowie" }
                });

            migrationBuilder.InsertData(
                table: "TrainingProposalsLikes",
                columns: new[] { "TrainingProposalsId", "UserId", "Created", "Modified" },
                values: new object[] { new Guid("02f3ef91-2894-414d-adc2-c24a78400a12"), new Guid("893a3823-2412-4d04-8f66-0f09cc52c788"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "TrainingProposalsLikes",
                columns: new[] { "TrainingProposalsId", "UserId", "Created", "Modified" },
                values: new object[] { new Guid("02f3ef91-2894-414d-adc2-c24a78400a12"), new Guid("3779b923-f7e2-4ba0-8f18-c7fcdc9f6eb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });
        }
    }
}
