using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task1_ASP.NET_Core_API.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpolyeeTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Department = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressNumber = table.Column<int>(type: "int", nullable: false),
                    AddressStreet = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpolyeeTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProspectTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressNumber = table.Column<int>(type: "int", nullable: false),
                    AddressStreet = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CustomerTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProspectId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressNumber = table.Column<int>(type: "int", nullable: false),
                    AddressStreet = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerTable_ProspectTable_ProspectId",
                        column: x => x.ProspectId,
                        principalTable: "ProspectTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProspectEmpolyeeTable",
                columns: table => new
                {
                    ProspectId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProspectEmpolyeeTable", x => new { x.ProspectId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_ProspectEmpolyeeTable_EmpolyeeTable_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmpolyeeTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProspectEmpolyeeTable_ProspectTable_ProspectId",
                        column: x => x.ProspectId,
                        principalTable: "ProspectTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerEmployeeTable",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerEmployeeTable", x => new { x.CustomerId, x.EmployeeId });
                    table.ForeignKey(
                        name: "FK_CustomerEmployeeTable_CustomerTable_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "CustomerTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerEmployeeTable_EmpolyeeTable_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmpolyeeTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerEmployeeTable_EmployeeId",
                table: "CustomerEmployeeTable",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerTable_ProspectId",
                table: "CustomerTable",
                column: "ProspectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProspectEmpolyeeTable_EmployeeId",
                table: "ProspectEmpolyeeTable",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerEmployeeTable");

            migrationBuilder.DropTable(
                name: "ProspectEmpolyeeTable");

            migrationBuilder.DropTable(
                name: "CustomerTable");

            migrationBuilder.DropTable(
                name: "EmpolyeeTable");

            migrationBuilder.DropTable(
                name: "ProspectTable");
        }
    }
}
