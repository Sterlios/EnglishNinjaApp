using EntityFramework;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBMigration.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"CREATE SCHEMA {EnglishNinjaConfig.PeopleSchemaName};");
            migrationBuilder.Sql($"CREATE SCHEMA {EnglishNinjaConfig.EnglishSchemaName};");

            migrationBuilder.CreateTable(
                name: "Users",
                schema: EnglishNinjaConfig.PeopleSchemaName,
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "NVARCHAR(Max)", nullable: false),
                    Surname = table.Column<string>(type: "NVARCHAR(Max)", nullable: false),
                    Birthday = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table => table.PrimaryKey("PK_Users", user => user.Id)
                );

            migrationBuilder.CreateTable(
                name: "Students",
                schema: EnglishNinjaConfig.PeopleSchemaName,
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false),
                    LevelId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "Date", nullable: false),
                },
                constraints: table => table.PrimaryKey("PK_Students", student => student.Id)
                );

            migrationBuilder.CreateTable(
                name: "Levels",
                schema: EnglishNinjaConfig.EnglishSchemaName,
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false).Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "NVARCHAR(Max)", nullable: true),
                    ShortName = table.Column<string>(type: "NVARCHAR(Max)", nullable: true)
                },
                constraints: table => table.PrimaryKey("PK_Levels", level => level.Id)
                );

            migrationBuilder.AddForeignKey("FK_Student_User",
                schema: EnglishNinjaConfig.PeopleSchemaName, table: "Students", column: "UserId",
                principalSchema: EnglishNinjaConfig.PeopleSchemaName, principalTable: "Users", principalColumn: "Id");

            migrationBuilder.AddForeignKey("FK_Student_Level",
                schema: EnglishNinjaConfig.PeopleSchemaName, table: "Students", column: "LevelId",
                principalSchema: EnglishNinjaConfig.EnglishSchemaName, principalTable: "Levels", principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
