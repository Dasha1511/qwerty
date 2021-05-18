using Microsoft.EntityFrameworkCore.Migrations;

namespace qwerty.Migrations
{
    public partial class qqq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_predmet_predmet_predmetID",
                table: "predmet");

            migrationBuilder.DropForeignKey(
                name: "FK_vid_Class_ClassID",
                table: "vid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_vid",
                table: "vid");

            migrationBuilder.DropIndex(
                name: "IX_predmet_predmetID",
                table: "predmet");

            migrationBuilder.RenameTable(
                name: "vid",
                newName: "Vid");

            migrationBuilder.RenameIndex(
                name: "IX_vid_ClassID",
                table: "Vid",
                newName: "IX_Vid_ClassID");

            migrationBuilder.RenameColumn(
                name: "predmetID",
                table: "predmet",
                newName: "sotrudnikiID");

            migrationBuilder.AddColumn<long>(
                name: "ClassID",
                table: "students",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "predmetID",
                table: "sotrudniki",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "predmetID",
                table: "raspisanie",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "raspisanieID",
                table: "predmet",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "studentsID",
                table: "Class",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vid",
                table: "Vid",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_sotrudniki_predmetID",
                table: "sotrudniki",
                column: "predmetID");

            migrationBuilder.CreateIndex(
                name: "IX_predmet_raspisanieID",
                table: "predmet",
                column: "raspisanieID");

            migrationBuilder.CreateIndex(
                name: "IX_Class_studentsID",
                table: "Class",
                column: "studentsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_students_studentsID",
                table: "Class",
                column: "studentsID",
                principalTable: "students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_predmet_raspisanie_raspisanieID",
                table: "predmet",
                column: "raspisanieID",
                principalTable: "raspisanie",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sotrudniki_predmet_predmetID",
                table: "sotrudniki",
                column: "predmetID",
                principalTable: "predmet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vid_Class_ClassID",
                table: "Vid",
                column: "ClassID",
                principalTable: "Class",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_students_studentsID",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_predmet_raspisanie_raspisanieID",
                table: "predmet");

            migrationBuilder.DropForeignKey(
                name: "FK_sotrudniki_predmet_predmetID",
                table: "sotrudniki");

            migrationBuilder.DropForeignKey(
                name: "FK_Vid_Class_ClassID",
                table: "Vid");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vid",
                table: "Vid");

            migrationBuilder.DropIndex(
                name: "IX_sotrudniki_predmetID",
                table: "sotrudniki");

            migrationBuilder.DropIndex(
                name: "IX_predmet_raspisanieID",
                table: "predmet");

            migrationBuilder.DropIndex(
                name: "IX_Class_studentsID",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "ClassID",
                table: "students");

            migrationBuilder.DropColumn(
                name: "predmetID",
                table: "sotrudniki");

            migrationBuilder.DropColumn(
                name: "predmetID",
                table: "raspisanie");

            migrationBuilder.DropColumn(
                name: "raspisanieID",
                table: "predmet");

            migrationBuilder.DropColumn(
                name: "studentsID",
                table: "Class");

            migrationBuilder.RenameTable(
                name: "Vid",
                newName: "vid");

            migrationBuilder.RenameIndex(
                name: "IX_Vid_ClassID",
                table: "vid",
                newName: "IX_vid_ClassID");

            migrationBuilder.RenameColumn(
                name: "sotrudnikiID",
                table: "predmet",
                newName: "predmetID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_vid",
                table: "vid",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_predmet_predmetID",
                table: "predmet",
                column: "predmetID");

            migrationBuilder.AddForeignKey(
                name: "FK_predmet_predmet_predmetID",
                table: "predmet",
                column: "predmetID",
                principalTable: "predmet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_vid_Class_ClassID",
                table: "vid",
                column: "ClassID",
                principalTable: "Class",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
