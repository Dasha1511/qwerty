using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace qwerty.Migrations
{
    public partial class clcl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kolichestvo_uchenikov = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bukva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    God_obuchenia = table.Column<DateTime>(type: "datetime2", nullable: false),
                    God_sozdania = table.Column<DateTime>(type: "datetime2", nullable: false),
                    sotrudnikiID = table.Column<long>(type: "bigint", nullable: true),
                    vidID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "sotrudniki",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIO = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Old = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pasport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DolznostID = table.Column<long>(type: "bigint", nullable: true),
                    ClassID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sotrudniki", x => x.ID);
                    table.ForeignKey(
                        name: "FK_sotrudniki_Class_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Class",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "vid",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opisanie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClassID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vid", x => x.ID);
                    table.ForeignKey(
                        name: "FK_vid_Class_ClassID",
                        column: x => x.ClassID,
                        principalTable: "Class",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Dolznost",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naimenovanie_dolznosti = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Oklad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Obazannosty = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trebovania = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sotrudnikiID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dolznost", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Dolznost_sotrudniki_sotrudnikiID",
                        column: x => x.sotrudnikiID,
                        principalTable: "sotrudniki",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dolznost_sotrudnikiID",
                table: "Dolznost",
                column: "sotrudnikiID");

            migrationBuilder.CreateIndex(
                name: "IX_sotrudniki_ClassID",
                table: "sotrudniki",
                column: "ClassID");

            migrationBuilder.CreateIndex(
                name: "IX_vid_ClassID",
                table: "vid",
                column: "ClassID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dolznost");

            migrationBuilder.DropTable(
                name: "vid");

            migrationBuilder.DropTable(
                name: "sotrudniki");

            migrationBuilder.DropTable(
                name: "Class");
        }
    }
}
