using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalHospital.Services.Migrations
{
    public partial class AddNewRelationandPropinTapleRadiology : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "doctorId",
                table: "Radiologies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "radiologyStatus",
                table: "Radiologies",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Radiologies_doctorId",
                table: "Radiologies",
                column: "doctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Radiologies_Doctors_doctorId",
                table: "Radiologies",
                column: "doctorId",
                principalTable: "Doctors",
                principalColumn: "doctorId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Radiologies_Doctors_doctorId",
                table: "Radiologies");

            migrationBuilder.DropIndex(
                name: "IX_Radiologies_doctorId",
                table: "Radiologies");

            migrationBuilder.DropColumn(
                name: "doctorId",
                table: "Radiologies");

            migrationBuilder.DropColumn(
                name: "radiologyStatus",
                table: "Radiologies");
        }
    }
}
