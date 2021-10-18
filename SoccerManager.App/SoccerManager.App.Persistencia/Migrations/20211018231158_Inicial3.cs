using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerManager.App.Persistencia.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitros_Personas_personaId",
                table: "Arbitros");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Arbitros_arbitroId",
                table: "Campeonatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Canchas_canchaId",
                table: "Campeonatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Categorias_categoriaId",
                table: "Campeonatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Equipos_equipoId",
                table: "Campeonatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Modalidades_modalidadId",
                table: "Campeonatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Ramas_ramaId",
                table: "Campeonatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Jugadores_Equipos_equipoId",
                table: "Equipo_Jugadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Jugadores_Jugadores_jugadorId",
                table: "Equipo_Jugadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Partidos_Campos_campoId",
                table: "Equipo_Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Partidos_Equipos_equipoId",
                table: "Equipo_Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipo_Partidos_Partido_partidoId",
                table: "Equipo_Partidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Categorias_categoriaId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Ciudades_ciudadId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Jugadores_jugadorId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Modalidades_modalidadId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Ramas_ramaId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Campeonatos_campeonatoId",
                table: "Jugadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Personas_personaId",
                table: "Jugadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Partido_Jugadores_Jugadores_jugadorId",
                table: "Partido_Jugadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Partido_Jugadores_Partido_partidoId",
                table: "Partido_Jugadores");

            migrationBuilder.DropTable(
                name: "Partido");

            migrationBuilder.DropIndex(
                name: "IX_Partido_Jugadores_jugadorId",
                table: "Partido_Jugadores");

            migrationBuilder.DropIndex(
                name: "IX_Partido_Jugadores_partidoId",
                table: "Partido_Jugadores");

            migrationBuilder.DropIndex(
                name: "IX_Jugadores_campeonatoId",
                table: "Jugadores");

            migrationBuilder.DropIndex(
                name: "IX_Jugadores_personaId",
                table: "Jugadores");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_categoriaId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_ciudadId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_jugadorId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_modalidadId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipos_ramaId",
                table: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_Partidos_campoId",
                table: "Equipo_Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_Partidos_equipoId",
                table: "Equipo_Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_Partidos_partidoId",
                table: "Equipo_Partidos");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_Jugadores_equipoId",
                table: "Equipo_Jugadores");

            migrationBuilder.DropIndex(
                name: "IX_Equipo_Jugadores_jugadorId",
                table: "Equipo_Jugadores");

            migrationBuilder.DropIndex(
                name: "IX_Campeonatos_arbitroId",
                table: "Campeonatos");

            migrationBuilder.DropIndex(
                name: "IX_Campeonatos_canchaId",
                table: "Campeonatos");

            migrationBuilder.DropIndex(
                name: "IX_Campeonatos_categoriaId",
                table: "Campeonatos");

            migrationBuilder.DropIndex(
                name: "IX_Campeonatos_equipoId",
                table: "Campeonatos");

            migrationBuilder.DropIndex(
                name: "IX_Campeonatos_modalidadId",
                table: "Campeonatos");

            migrationBuilder.DropIndex(
                name: "IX_Campeonatos_ramaId",
                table: "Campeonatos");

            migrationBuilder.DropIndex(
                name: "IX_Arbitros_personaId",
                table: "Arbitros");

            migrationBuilder.DropColumn(
                name: "jugadorId",
                table: "Partido_Jugadores");

            migrationBuilder.DropColumn(
                name: "partidoId",
                table: "Partido_Jugadores");

            migrationBuilder.DropColumn(
                name: "campeonatoId",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "personaId",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "categoriaId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "ciudadId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "jugadorId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "modalidadId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "ramaId",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "campoId",
                table: "Equipo_Partidos");

            migrationBuilder.DropColumn(
                name: "equipoId",
                table: "Equipo_Partidos");

            migrationBuilder.DropColumn(
                name: "partidoId",
                table: "Equipo_Partidos");

            migrationBuilder.DropColumn(
                name: "equipoId",
                table: "Equipo_Jugadores");

            migrationBuilder.DropColumn(
                name: "jugadorId",
                table: "Equipo_Jugadores");

            migrationBuilder.DropColumn(
                name: "arbitroId",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "canchaId",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "categoriaId",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "equipoId",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "modalidadId",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "ramaId",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "personaId",
                table: "Arbitros");

            migrationBuilder.AddColumn<int>(
                name: "Jugador",
                table: "Partido_Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Partido",
                table: "Partido_Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Campeonato",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Persona",
                table: "Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Categoria",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Ciudad",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Jugador",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Modalidad",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rama",
                table: "Equipos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Campo",
                table: "Equipo_Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Equipo",
                table: "Equipo_Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Partido",
                table: "Equipo_Partidos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Equipo",
                table: "Equipo_Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Jugador",
                table: "Equipo_Jugadores",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Arbitro",
                table: "Campeonatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cancha",
                table: "Campeonatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Categoria",
                table: "Campeonatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Equipo",
                table: "Campeonatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Modalidad",
                table: "Campeonatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rama",
                table: "Campeonatos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Persona",
                table: "Arbitros",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Jugador",
                table: "Partido_Jugadores");

            migrationBuilder.DropColumn(
                name: "Partido",
                table: "Partido_Jugadores");

            migrationBuilder.DropColumn(
                name: "Campeonato",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "Persona",
                table: "Jugadores");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "Ciudad",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "Jugador",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "Modalidad",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "Rama",
                table: "Equipos");

            migrationBuilder.DropColumn(
                name: "Campo",
                table: "Equipo_Partidos");

            migrationBuilder.DropColumn(
                name: "Equipo",
                table: "Equipo_Partidos");

            migrationBuilder.DropColumn(
                name: "Partido",
                table: "Equipo_Partidos");

            migrationBuilder.DropColumn(
                name: "Equipo",
                table: "Equipo_Jugadores");

            migrationBuilder.DropColumn(
                name: "Jugador",
                table: "Equipo_Jugadores");

            migrationBuilder.DropColumn(
                name: "Arbitro",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "Cancha",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "Categoria",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "Equipo",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "Modalidad",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "Rama",
                table: "Campeonatos");

            migrationBuilder.DropColumn(
                name: "Persona",
                table: "Arbitros");

            migrationBuilder.AddColumn<int>(
                name: "jugadorId",
                table: "Partido_Jugadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "partidoId",
                table: "Partido_Jugadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "campeonatoId",
                table: "Jugadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "personaId",
                table: "Jugadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "categoriaId",
                table: "Equipos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ciudadId",
                table: "Equipos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jugadorId",
                table: "Equipos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "modalidadId",
                table: "Equipos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ramaId",
                table: "Equipos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "campoId",
                table: "Equipo_Partidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "equipoId",
                table: "Equipo_Partidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "partidoId",
                table: "Equipo_Partidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "equipoId",
                table: "Equipo_Jugadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "jugadorId",
                table: "Equipo_Jugadores",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "arbitroId",
                table: "Campeonatos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "canchaId",
                table: "Campeonatos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "categoriaId",
                table: "Campeonatos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "equipoId",
                table: "Campeonatos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "modalidadId",
                table: "Campeonatos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ramaId",
                table: "Campeonatos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "personaId",
                table: "Arbitros",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Partido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    arbitroId = table.Column<int>(type: "int", nullable: true),
                    equipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partido_Arbitros_arbitroId",
                        column: x => x.arbitroId,
                        principalTable: "Arbitros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partido_Equipos_equipoId",
                        column: x => x.equipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partido_Jugadores_jugadorId",
                table: "Partido_Jugadores",
                column: "jugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_Jugadores_partidoId",
                table: "Partido_Jugadores",
                column: "partidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_campeonatoId",
                table: "Jugadores",
                column: "campeonatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_personaId",
                table: "Jugadores",
                column: "personaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_categoriaId",
                table: "Equipos",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_ciudadId",
                table: "Equipos",
                column: "ciudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_jugadorId",
                table: "Equipos",
                column: "jugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_modalidadId",
                table: "Equipos",
                column: "modalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipos_ramaId",
                table: "Equipos",
                column: "ramaId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_Partidos_campoId",
                table: "Equipo_Partidos",
                column: "campoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_Partidos_equipoId",
                table: "Equipo_Partidos",
                column: "equipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_Partidos_partidoId",
                table: "Equipo_Partidos",
                column: "partidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_Jugadores_equipoId",
                table: "Equipo_Jugadores",
                column: "equipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_Jugadores_jugadorId",
                table: "Equipo_Jugadores",
                column: "jugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Campeonatos_arbitroId",
                table: "Campeonatos",
                column: "arbitroId");

            migrationBuilder.CreateIndex(
                name: "IX_Campeonatos_canchaId",
                table: "Campeonatos",
                column: "canchaId");

            migrationBuilder.CreateIndex(
                name: "IX_Campeonatos_categoriaId",
                table: "Campeonatos",
                column: "categoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Campeonatos_equipoId",
                table: "Campeonatos",
                column: "equipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Campeonatos_modalidadId",
                table: "Campeonatos",
                column: "modalidadId");

            migrationBuilder.CreateIndex(
                name: "IX_Campeonatos_ramaId",
                table: "Campeonatos",
                column: "ramaId");

            migrationBuilder.CreateIndex(
                name: "IX_Arbitros_personaId",
                table: "Arbitros",
                column: "personaId");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_arbitroId",
                table: "Partido",
                column: "arbitroId");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_equipoId",
                table: "Partido",
                column: "equipoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arbitros_Personas_personaId",
                table: "Arbitros",
                column: "personaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campeonatos_Arbitros_arbitroId",
                table: "Campeonatos",
                column: "arbitroId",
                principalTable: "Arbitros",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campeonatos_Canchas_canchaId",
                table: "Campeonatos",
                column: "canchaId",
                principalTable: "Canchas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campeonatos_Categorias_categoriaId",
                table: "Campeonatos",
                column: "categoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campeonatos_Equipos_equipoId",
                table: "Campeonatos",
                column: "equipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campeonatos_Modalidades_modalidadId",
                table: "Campeonatos",
                column: "modalidadId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Campeonatos_Ramas_ramaId",
                table: "Campeonatos",
                column: "ramaId",
                principalTable: "Ramas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Jugadores_Equipos_equipoId",
                table: "Equipo_Jugadores",
                column: "equipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Jugadores_Jugadores_jugadorId",
                table: "Equipo_Jugadores",
                column: "jugadorId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Partidos_Campos_campoId",
                table: "Equipo_Partidos",
                column: "campoId",
                principalTable: "Campos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Partidos_Equipos_equipoId",
                table: "Equipo_Partidos",
                column: "equipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipo_Partidos_Partido_partidoId",
                table: "Equipo_Partidos",
                column: "partidoId",
                principalTable: "Partido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Categorias_categoriaId",
                table: "Equipos",
                column: "categoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Ciudades_ciudadId",
                table: "Equipos",
                column: "ciudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Jugadores_jugadorId",
                table: "Equipos",
                column: "jugadorId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Modalidades_modalidadId",
                table: "Equipos",
                column: "modalidadId",
                principalTable: "Modalidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Equipos_Ramas_ramaId",
                table: "Equipos",
                column: "ramaId",
                principalTable: "Ramas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadores_Campeonatos_campeonatoId",
                table: "Jugadores",
                column: "campeonatoId",
                principalTable: "Campeonatos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadores_Personas_personaId",
                table: "Jugadores",
                column: "personaId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partido_Jugadores_Jugadores_jugadorId",
                table: "Partido_Jugadores",
                column: "jugadorId",
                principalTable: "Jugadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Partido_Jugadores_Partido_partidoId",
                table: "Partido_Jugadores",
                column: "partidoId",
                principalTable: "Partido",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
