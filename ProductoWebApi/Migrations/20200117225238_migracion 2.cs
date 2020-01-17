using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductoWebApi.Migrations
{
    public partial class migracion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descricion",
                table: "Producto",
                newName: "Descripcion");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Descripcion",
                table: "Producto",
                newName: "Descricion");
        }
    }
}
