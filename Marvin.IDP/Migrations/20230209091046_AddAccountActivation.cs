using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountActivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("24510b7f-3769-4f66-bff4-f69237b5ef3c"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("256a5e50-15ee-4765-bebc-199039866d8a"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4f602a24-3620-4b09-bcd0-65b12340e7cb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4fd27cdc-d7b0-47dc-8cca-91290cb58c0f"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7b9a7915-1055-461a-9fd9-45d451d99cb0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b2c3512f-3ee1-4d23-9693-e5f927a19547"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b35b8227-8728-4c18-a934-dcf5baf66d9b"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f164dc38-29fd-42c1-820a-e744d9b83910"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("0b1fbfa5-2347-4734-987c-d56f60935420"), "3baee229-5020-4877-8938-7ffa1c84aa2d", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("5795cc76-5e38-43d1-8bdb-3a97d71749bc"), "d7d93c75-148d-43a8-b505-fd9cf2b70ccb", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("76a6b1a8-94ae-40ec-a8c1-c0e4d66491eb"), "15cc2291-b1ec-407d-8a6c-9ad4997914fa", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("8211597f-d252-4b39-b768-c8fd4ef1acdd"), "470be50e-100c-4bea-bf6d-8bc5c4ec8a0b", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("b503137e-5f5f-40f9-af55-bdb561963e48"), "00b7f06d-eb09-476a-9ac5-aba10602c672", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("b9d36a73-6c05-42f9-a98a-f3d62c84d530"), "636cdd19-574e-471b-860c-703c0e19b922", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("c1cf11aa-59a7-4196-b133-d9125e1b3130"), "ca34e724-a283-4930-ac40-9c0d93a98027", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("dffd5b92-04ae-49a6-8e16-775dad5c1f41"), "af24c8d8-9a4e-48e4-bdf9-d7ddc46128a5", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "ec4128a3-81bb-4da6-b575-e3c18f25bec6", "david@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "818842b2-fae9-4619-a7fe-c9da57259224", "emma@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("0b1fbfa5-2347-4734-987c-d56f60935420"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("5795cc76-5e38-43d1-8bdb-3a97d71749bc"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("76a6b1a8-94ae-40ec-a8c1-c0e4d66491eb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8211597f-d252-4b39-b768-c8fd4ef1acdd"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b503137e-5f5f-40f9-af55-bdb561963e48"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b9d36a73-6c05-42f9-a98a-f3d62c84d530"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c1cf11aa-59a7-4196-b133-d9125e1b3130"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("dffd5b92-04ae-49a6-8e16-775dad5c1f41"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("24510b7f-3769-4f66-bff4-f69237b5ef3c"), "ebc48c7c-cfd4-41a5-a72a-4c22f2af1a20", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("256a5e50-15ee-4765-bebc-199039866d8a"), "d2a2c7df-c046-4a48-b460-8577bea8ec3a", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("4f602a24-3620-4b09-bcd0-65b12340e7cb"), "45837bdd-af6a-4564-ab22-5ca7bb8643b0", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("4fd27cdc-d7b0-47dc-8cca-91290cb58c0f"), "bb059ef0-782f-47c8-9fae-60b4b244142f", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("7b9a7915-1055-461a-9fd9-45d451d99cb0"), "77c8e7c2-0dd2-4a79-9a42-f5fe74e4a98a", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("b2c3512f-3ee1-4d23-9693-e5f927a19547"), "7b6085a7-f506-4fd2-ac3b-695ffe1a556e", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("b35b8227-8728-4c18-a934-dcf5baf66d9b"), "60d3b842-1486-427c-9921-150afe2ee53f", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("f164dc38-29fd-42c1-820a-e744d9b83910"), "74624552-b57d-44c9-8532-388f854d305f", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "35eafde8-4e49-4e4b-afab-6c7a64029e82");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "ecbfe26d-1d92-4705-9e79-96e05e40462e");
        }
    }
}
