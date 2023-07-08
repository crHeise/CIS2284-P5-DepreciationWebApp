using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HeiseP5.Migrations
{
    public partial class InitialCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InventoryItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: true),
                    isActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateRemoved = table.Column<DateTime>(type: "TEXT", nullable: false),
                    StartValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    SalvageValue = table.Column<decimal>(type: "TEXT", nullable: false),
                    LifeTime = table.Column<int>(type: "INTEGER", nullable: false),
                    CurrentValue = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "CurrentValue", "DateAdded", "DateRemoved", "LifeTime", "SalvageValue", "StartValue", "Title", "isActive" },
                values: new object[] { 1001, 10.0m, new DateTime(2015, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 20, 5.0m, 50.0m, "Desk Lamp", true });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "CurrentValue", "DateAdded", "DateRemoved", "LifeTime", "SalvageValue", "StartValue", "Title", "isActive" },
                values: new object[] { 1002, 80.27397260273972602739726027m, new DateTime(2021, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 10, 20.0m, 250.0m, "Computer Monitor", true });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "CurrentValue", "DateAdded", "DateRemoved", "LifeTime", "SalvageValue", "StartValue", "Title", "isActive" },
                values: new object[] { 1003, 10.0m, new DateTime(2005, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, 0.5m, 15.0m, "Coffee Cup", false });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "CurrentValue", "DateAdded", "DateRemoved", "LifeTime", "SalvageValue", "StartValue", "Title", "isActive" },
                values: new object[] { 1004, 10.0m, new DateTime(2018, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 10, 10.0m, 100.0m, "Keyboard", true });

            migrationBuilder.InsertData(
                table: "InventoryItems",
                columns: new[] { "Id", "CurrentValue", "DateAdded", "DateRemoved", "LifeTime", "SalvageValue", "StartValue", "Title", "isActive" },
                values: new object[] { 1005, 10.0m, new DateTime(2019, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 11, 3, 0, 0, 0, 0, DateTimeKind.Local), 5, 15.0m, 75.0m, "Wireless Speaker", true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InventoryItems");
        }
    }
}
