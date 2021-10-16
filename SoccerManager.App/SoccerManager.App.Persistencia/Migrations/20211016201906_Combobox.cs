using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerManager.App.Persistencia.Migrations
{
    public partial class Combobox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Ciudades_ciudadId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Generos_generoId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Perfiles_perfilId",
                table: "Personas");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Tipos_Documentos_tipo_documentoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_ciudadId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_generoId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_perfilId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_tipo_documentoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "ciudadId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "generoId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "perfilId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "tipo_documentoId",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "Ciudad",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Genero",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Perfil",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Tipo_Documento",
                table: "Personas",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "Tipo_Documento",
                table: "Personas");

            migrationBuilder.AddColumn<int>(
                name: "ciudadId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "generoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "perfilId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tipo_documentoId",
                table: "Personas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_ciudadId",
                table: "Personas",
                column: "ciudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_generoId",
                table: "Personas",
                column: "generoId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_perfilId",
                table: "Personas",
                column: "perfilId");

            migrationBuilder.CreateIndex(
                name: "IX_Personas_tipo_documentoId",
                table: "Personas",
                column: "tipo_documentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Ciudades_ciudadId",
                table: "Personas",
                column: "ciudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Generos_generoId",
                table: "Personas",
                column: "generoId",
                principalTable: "Generos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Perfiles_perfilId",
                table: "Personas",
                column: "perfilId",
                principalTable: "Perfiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Tipos_Documentos_tipo_documentoId",
                table: "Personas",
                column: "tipo_documentoId",
                principalTable: "Tipos_Documentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
