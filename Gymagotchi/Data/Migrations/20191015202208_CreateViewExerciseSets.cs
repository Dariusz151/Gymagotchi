using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymagotchi.Data.Migrations
{
    public partial class CreateViewExerciseSets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"CREATE VIEW [dbo].[v_ExerciseSets] AS (
	            SELECT
		            [ExerciseSets].[Id],
		            [v_Exercises].[Name],
		            [v_Exercises].[Desc],
		            [v_Exercises].[Category],
		            [v_Exercises].[Mode],
		            [ExerciseSets].[Repeats],
		            [ExerciseSets].[SetsAmount],
		            [ExerciseSets].[Load],
		            [ExerciseSets].[Timestamp]
	            FROM
		            [dbo].[ExerciseSets]
	            LEFT JOIN [dbo].[v_Exercises]
		            ON [dbo].[v_Exercises].[Id] = [ExerciseSets].[ExerciseId]
                )");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW [dbo].[v_ExerciseSets]");
        }
    }
}
