using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymagotchi.Data.Migrations
{
    public partial class AddedEnumsToExercise : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ExerciseMode",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "ExerciseCategory",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ExerciseMode",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "ExerciseCategory",
                table: "Exercises",
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
