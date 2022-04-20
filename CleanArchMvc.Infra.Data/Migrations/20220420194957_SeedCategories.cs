using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class SeedCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories(Name)" +
                "VALUES('Pequeno-Almoço')");

            migrationBuilder.Sql("INSERT INTO Categories(Name)" +
                "VALUES('Almoço/Jantar')");

            migrationBuilder.Sql("INSERT INTO Categories(Name)" +
                "VALUES('Brunch')");

            migrationBuilder.Sql("INSERT INTO Categories(Name)" +
                "VALUES('Sobremesa')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categories");
        }
    }
}
