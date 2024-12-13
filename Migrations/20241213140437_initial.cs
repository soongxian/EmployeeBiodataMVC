using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeBiodataMVC.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee_Biodata",
                columns: table => new
                {
                    employee_no = table.Column<string>(type: "VARCHAR(10)", nullable: false),
                    employee_name = table.Column<string>(type: "VARCHAR(60)", nullable: false),
                    birth_date = table.Column<DateTime>(type: "DATETIME", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Biodata", x => x.employee_no);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employee_Biodata");
        }
    }
}
