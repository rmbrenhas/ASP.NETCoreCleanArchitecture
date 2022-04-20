using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchMvc.Infra.Data.Migrations
{
    public partial class SeedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
               "VALUES('Tábua 1', 'Lorem ipsum dolor sit amet, consectetur adipiscing elit.', 30.45, 20, 'tabua1.jpg', 1)");

            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
               "VALUES('Tábua 2', 'Duis id rutrum ipsum. Etiam faucibus efficitur volutpat.', 20.50, 10, 'tabua2.jpg', 2)");

            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
               "VALUES('Tábua 3', 'Aliquam hendrerit posuere dolor ut condimentum.', 35.90, 5, 'tabua3.jpg', 3)");

            migrationBuilder.Sql("INSERT INTO Products(Name, Description, Price, Stock, Image, CategoryId)" +
               "VALUES('Tábua 4', 'Aliquam hendrerit posuere dolor ut condimentum.', 45.90, 15, 'tabua4.jpg', 3)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Products");
        }
    }
}
