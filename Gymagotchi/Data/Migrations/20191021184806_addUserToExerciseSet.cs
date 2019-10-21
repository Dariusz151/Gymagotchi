using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymagotchi.Data.Migrations
{
    public partial class addUserToExerciseSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ExerciseSets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseSets_UserId",
                table: "ExerciseSets",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseSets_AspNetUsers_UserId",
                table: "ExerciseSets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseSets_AspNetUsers_UserId",
                table: "ExerciseSets");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseSets_UserId",
                table: "ExerciseSets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ExerciseSets");
        }
    }
}
