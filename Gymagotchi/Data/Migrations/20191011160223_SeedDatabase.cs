using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymagotchi.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [ExerciseCategories] (Category) " +
                "VALUES ('Biceps'), ('Triceps'), ('Back'), ('Legs')");
            migrationBuilder.Sql("INSERT INTO [ExerciseModes] (Mode) VALUES ('Narrow'), ('Wide'), ('Middle')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [ExerciseCategories]");
            migrationBuilder.Sql("DELETE FROM [ExerciseModes]");
        }
    }
}
