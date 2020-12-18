using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiPrueba.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Solicitud_Casa_CasaId",
                table: "Solicitud");

            migrationBuilder.DropIndex(
                name: "IX_Solicitud_CasaId",
                table: "Solicitud");

            migrationBuilder.DropColumn(
                name: "CasaId",
                table: "Solicitud");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CasaId",
                table: "Solicitud",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Solicitud_CasaId",
                table: "Solicitud",
                column: "CasaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Solicitud_Casa_CasaId",
                table: "Solicitud",
                column: "CasaId",
                principalTable: "Casa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
