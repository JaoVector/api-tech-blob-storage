using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaciaAPI.Migrations
{
    public partial class TesteBlob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Produtos_ProdutoId",
                table: "Imagens");

            migrationBuilder.AddColumn<int>(
                name: "ProdutosProdutoId",
                table: "Imagens",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_ProdutosProdutoId",
                table: "Imagens",
                column: "ProdutosProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Produtos_ProdutosProdutoId",
                table: "Imagens",
                column: "ProdutosProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Produtos_ProdutosProdutoId",
                table: "Imagens");

            migrationBuilder.DropIndex(
                name: "IX_Imagens_ProdutosProdutoId",
                table: "Imagens");

            migrationBuilder.DropColumn(
                name: "ProdutosProdutoId",
                table: "Imagens");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Produtos_ProdutoId",
                table: "Imagens",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
