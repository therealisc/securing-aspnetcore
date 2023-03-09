using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddUserLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Provider = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    ProviderIdentityKey = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("6174d764-6932-4da1-a30b-8fe44da1e336"), "5f37acac-b00e-45fc-af3b-8e72c30b6257", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("7371b78c-bc50-49ed-8fe2-40c5b488bffc"), "a236a8d3-a685-4f96-9ae5-8affac9fdbd9", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("9143e072-55e7-4695-98f3-5fc04f01900e"), "aa3dfc38-6334-4faf-85e4-dc57d897b1c1", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("b9e82ef5-199e-4fb5-bf7f-02f2d9624239"), "5f330163-bedf-4725-b013-2792a79230aa", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("c635217a-c310-4209-af95-6a1691473653"), "ab9e47e2-6d3b-4649-85a0-47bf55b0bd8f", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("d7d5c7bb-6e36-423b-b219-593cd38f09cf"), "0d76bfcb-315b-4a87-9810-1ab31913129b", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("f35b337c-fcfa-4ed9-a0b7-cc05434d5e04"), "15366e52-5959-4b62-a3d1-084a346fd1cf", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("fccd84d7-4810-4053-8aea-327665013ca7"), "e107ec26-7e8b-4bfc-a744-1c9b0514681d", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "a7e63219-7b81-4f74-915b-11901e67c647", new DateTime(2023, 3, 10, 10, 1, 27, 209, DateTimeKind.Utc).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "d97135dd-588b-41d2-a06d-b1af8a73eadf", new DateTime(2023, 3, 10, 10, 1, 27, 209, DateTimeKind.Utc).AddTicks(2632) });

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("6174d764-6932-4da1-a30b-8fe44da1e336"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("7371b78c-bc50-49ed-8fe2-40c5b488bffc"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("9143e072-55e7-4695-98f3-5fc04f01900e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b9e82ef5-199e-4fb5-bf7f-02f2d9624239"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c635217a-c310-4209-af95-6a1691473653"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("d7d5c7bb-6e36-423b-b219-593cd38f09cf"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("f35b337c-fcfa-4ed9-a0b7-cc05434d5e04"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("fccd84d7-4810-4053-8aea-327665013ca7"));

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
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "ec4128a3-81bb-4da6-b575-e3c18f25bec6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "SecurityCodeExpirationDate" },
                values: new object[] { "818842b2-fae9-4619-a7fe-c9da57259224", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
