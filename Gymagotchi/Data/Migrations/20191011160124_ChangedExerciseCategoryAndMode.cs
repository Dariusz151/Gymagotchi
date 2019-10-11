using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymagotchi.Data.Migrations
{
    public partial class ChangedExerciseCategoryAndMode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseSet_Exercises_ExerciseId",
                table: "ExerciseSet");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseSet_Workouts_WorkoutId",
                table: "ExerciseSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseSet",
                table: "ExerciseSet");

            migrationBuilder.DropColumn(
                name: "ExerciseCategory",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ExerciseMode",
                table: "Exercises");

            migrationBuilder.RenameTable(
                name: "ExerciseSet",
                newName: "ExerciseSets");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseSet_WorkoutId",
                table: "ExerciseSets",
                newName: "IX_ExerciseSets_WorkoutId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseSet_ExerciseId",
                table: "ExerciseSets",
                newName: "IX_ExerciseSets_ExerciseId");

            migrationBuilder.AddColumn<int>(
                name: "ExerciseCategoryId",
                table: "Exercises",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ExerciseModeId",
                table: "Exercises",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseSets",
                table: "ExerciseSets",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ExerciseCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExerciseModes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Mode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseModes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseCategoryId",
                table: "Exercises",
                column: "ExerciseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Exercises_ExerciseModeId",
                table: "Exercises",
                column: "ExerciseModeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_ExerciseCategories_ExerciseCategoryId",
                table: "Exercises",
                column: "ExerciseCategoryId",
                principalTable: "ExerciseCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Exercises_ExerciseModes_ExerciseModeId",
                table: "Exercises",
                column: "ExerciseModeId",
                principalTable: "ExerciseModes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseSets_Exercises_ExerciseId",
                table: "ExerciseSets",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseSets_Workouts_WorkoutId",
                table: "ExerciseSets",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_ExerciseCategories_ExerciseCategoryId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_Exercises_ExerciseModes_ExerciseModeId",
                table: "Exercises");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseSets_Exercises_ExerciseId",
                table: "ExerciseSets");

            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseSets_Workouts_WorkoutId",
                table: "ExerciseSets");

            migrationBuilder.DropTable(
                name: "ExerciseCategories");

            migrationBuilder.DropTable(
                name: "ExerciseModes");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_ExerciseCategoryId",
                table: "Exercises");

            migrationBuilder.DropIndex(
                name: "IX_Exercises_ExerciseModeId",
                table: "Exercises");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExerciseSets",
                table: "ExerciseSets");

            migrationBuilder.DropColumn(
                name: "ExerciseCategoryId",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ExerciseModeId",
                table: "Exercises");

            migrationBuilder.RenameTable(
                name: "ExerciseSets",
                newName: "ExerciseSet");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseSets_WorkoutId",
                table: "ExerciseSet",
                newName: "IX_ExerciseSet_WorkoutId");

            migrationBuilder.RenameIndex(
                name: "IX_ExerciseSets_ExerciseId",
                table: "ExerciseSet",
                newName: "IX_ExerciseSet_ExerciseId");

            migrationBuilder.AddColumn<string>(
                name: "ExerciseCategory",
                table: "Exercises",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ExerciseMode",
                table: "Exercises",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExerciseSet",
                table: "ExerciseSet",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseSet_Exercises_ExerciseId",
                table: "ExerciseSet",
                column: "ExerciseId",
                principalTable: "Exercises",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseSet_Workouts_WorkoutId",
                table: "ExerciseSet",
                column: "WorkoutId",
                principalTable: "Workouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
