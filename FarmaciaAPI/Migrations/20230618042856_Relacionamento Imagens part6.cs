using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FarmaciaAPI.Migrations
{
    public partial class RelacionamentoImagenspart6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagem_Produtos_ProdutoId",
                table: "Imagem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imagem",
                table: "Imagem");

            migrationBuilder.RenameTable(
                name: "Imagem",
                newName: "Imagens");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Imagens",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imagens",
                table: "Imagens",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Imagens_ProdutoId",
                table: "Imagens",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagens_Produtos_ProdutoId",
                table: "Imagens",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Imagens_Produtos_ProdutoId",
                table: "Imagens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Imagens",
                table: "Imagens");

            migrationBuilder.DropIndex(
                name: "IX_Imagens_ProdutoId",
                table: "Imagens");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Imagens");

            migrationBuilder.RenameTable(
                name: "Imagens",
                newName: "Imagem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Imagem",
                table: "Imagem",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Imagem_Produtos_ProdutoId",
                table: "Imagem",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "ProdutoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
