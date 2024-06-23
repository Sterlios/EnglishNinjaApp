using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBMigration.Migrations
{
    /// <inheritdoc />
    public partial class AddUserInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>("Phone", "Users", "NVARCHAR(18)");
            migrationBuilder.AddColumn<DateTime>("BirthDay", "Users", "DATE");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
