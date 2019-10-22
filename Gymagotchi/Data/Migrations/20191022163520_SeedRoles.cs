using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymagotchi.Data.Migrations
{
    public partial class SeedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO [AspNetRoles] (Id, [Name], NormalizedName, ConcurrencyStamp) VALUES ('bbad8cdb-ee86-4c55-96ba-16f742058a80', 'Admin', 'ADMIN', NULL),
   ('bbad8cdb-ee86-4c55-96ba-16f742058a79', 'User', 'USER', NULL),
    ('bbad8cdb-ee86-4c55-96ba-16f742058a78', 'Moderator', 'MODERATOR', NULL)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DELETE FROM [AspNetRoles]");
        }
    }
}
