using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gaming.Migrations
{
    public partial class gamingMGRT : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Userss",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMAIL = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PASSWORD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USER_NAME = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    NAME = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    SURNAME = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    BIRTH_DATE = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TELEPHONE_NUMBER = table.Column<string>(type: "nvarchar(30)", nullable: true),
                    GENDER = table.Column<string>(type: "nvarchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userss", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Userss");
        }
    }
}
