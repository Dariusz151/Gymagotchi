using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymagotchi.Data.Migrations
{
    public partial class AddExerciseView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("CREATE VIEW [dbo].[v_Exercises] AS(" +
                "SELECT [Exercises].[Id], [Exercises].[Name], [Exercises].[Desc], [Categories].[Category], [Modes].[Mode]FROM [dbo].[Exercises]" +
                "LEFT JOIN [dbo].[ExerciseCategories] as [Categories] " +
                "ON [Categories].[Id] = [Exercises].[ExerciseCategoryId] " +
                "LEFT JOIN [dbo].[ExerciseModes] as [Modes] " +
                "ON [Modes].[Id] = [Exercises].[ExerciseModeId])");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW [dbo].[v_Exercises]");
        }
    }
}
