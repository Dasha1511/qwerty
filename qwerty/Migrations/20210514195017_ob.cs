using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace qwerty.Migrations
{
    public partial class ob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "raspisanieID",
                table: "Class",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "predmet",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opisanie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    predmetID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_predmet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_predmet_predmet_predmetID",
                        column: x => x.predmetID,
                        principalTable: "predmet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "raspisanie",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Den_nedeli = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vrema_nachala = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vrema_okonchania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    classID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raspisanie", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_rozdenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Pol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FIO_ot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FIO_mat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dopolnitelnaya_inf = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_students", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Class_raspisanieID",
                table: "Class",
                column: "raspisanieID");

            migrationBuilder.CreateIndex(
                name: "IX_predmet_predmetID",
                table: "predmet",
                column: "predmetID");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_raspisanie_raspisanieID",
                table: "Class",
                column: "raspisanieID",
                principalTable: "raspisanie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_raspisanie_raspisanieID",
                table: "Class");

            migrationBuilder.DropTable(
                name: "predmet");

            migrationBuilder.DropTable(
                name: "raspisanie");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropIndex(
                name: "IX_Class_raspisanieID",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "raspisanieID",
                table: "Class");
        }
    }
}
