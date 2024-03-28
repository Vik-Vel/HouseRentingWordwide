using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentitngSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42df13d1-1c5e-48ba-ad36-69b37193dc34", "AQAAAAEAACcQAAAAECDbdDyF+eNkFB4dzi2za9c1cpcTK7NF/WYzcRXXqwaIWAsm3sm6qg1xthLed/3u/g==", "ca376d01-a429-4acc-9f32-d0cef18ca397" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d76eca5-e92f-4dca-b699-bd6b72721e0b", "AQAAAAEAACcQAAAAEIZBdyJaw/Lw5y2HMZq22b0L89/GRu/kIG2NexyCiBcdVUvgKDD+fc9Jwh6ntZ7QdA==", "8792910e-3a81-4818-a7d6-4c6525a1b392" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89d7ed6f-d971-41b4-85d4-baa2ac21d157", "AQAAAAEAACcQAAAAECOKUyslVcDBwFYk5Jow6jgTCEWXMVk2pWqZWgreDtoFrowxGOMNhUq5RDN6UJaM/w==", "c9725c88-3620-4553-b2a5-d80543a8b83c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c274f528-d8eb-4cfb-a464-550d5dd6a0a6", "AQAAAAEAACcQAAAAEMP9l9jl/A9dBNK+XsCetFMslL8+KOT5e+UopgmmiOLNeC9u5ZVeaLtC5Q4YlCjp7A==", "c96a7da3-0856-4a57-ac6f-6fc16da803df" });
        }
    }
}
