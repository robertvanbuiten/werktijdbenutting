using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("89220428-2907-4a12-a78f-38e47923dc21"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("e5f416c0-a8e1-43c1-9d29-cbb6bf388a5c"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("94fed9fe-f319-4c8d-94df-f9e0762c54ba"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("8fff309a-fc34-40c1-9c4b-773d9d5ab8e2"));

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Branch", "CompanyType", "DateOfEstablishment", "Logo", "Name", "Phonenumber" },
                values: new object[] { new Guid("516d7328-24bb-4de3-9162-b150aa6726b3"), "ICT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Test Bedrijf", 121212121 });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Branch", "CompanyType", "DateOfEstablishment", "Logo", "Name", "Phonenumber" },
                values: new object[] { new Guid("1c031c4d-c8c5-4a9b-a025-d75f8e9aae9e"), "HRM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Test Bedrijf 2", 121212121 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "City", "Description", "OrganizationId", "PostalCode" },
                values: new object[] { new Guid("dd3adb18-8137-4815-a877-8bd1373c793a"), "Testweg 1", "Tuk", null, new Guid("516d7328-24bb-4de3-9162-b150aa6726b3"), "8334 RK" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "City", "Description", "OrganizationId", "PostalCode" },
                values: new object[] { new Guid("b1cbab0b-5db0-4fa4-b2a0-7fcdcfb6b8ff"), "Testweg 2", "De Basse", null, new Guid("516d7328-24bb-4de3-9162-b150aa6726b3"), "8334 RK" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("b1cbab0b-5db0-4fa4-b2a0-7fcdcfb6b8ff"));

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: new Guid("dd3adb18-8137-4815-a877-8bd1373c793a"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("1c031c4d-c8c5-4a9b-a025-d75f8e9aae9e"));

            migrationBuilder.DeleteData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: new Guid("516d7328-24bb-4de3-9162-b150aa6726b3"));

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Branch", "CompanyType", "DateOfEstablishment", "Logo", "Name", "Phonenumber" },
                values: new object[] { new Guid("8fff309a-fc34-40c1-9c4b-773d9d5ab8e2"), "ICT", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Test Bedrijf", 121212121 });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Branch", "CompanyType", "DateOfEstablishment", "Logo", "Name", "Phonenumber" },
                values: new object[] { new Guid("94fed9fe-f319-4c8d-94df-f9e0762c54ba"), "HRM", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Test Bedrijf 2", 121212121 });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "City", "Description", "OrganizationId", "PostalCode" },
                values: new object[] { new Guid("e5f416c0-a8e1-43c1-9d29-cbb6bf388a5c"), "Testweg 1", "Tuk", null, new Guid("8fff309a-fc34-40c1-9c4b-773d9d5ab8e2"), "8334 RK" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Address", "City", "Description", "OrganizationId", "PostalCode" },
                values: new object[] { new Guid("89220428-2907-4a12-a78f-38e47923dc21"), "Testweg 2", "De Basse", null, new Guid("8fff309a-fc34-40c1-9c4b-773d9d5ab8e2"), "8334 RK" });
        }
    }
}
