using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerManager.App.Persistencia.Migrations
{
    public partial class Inicial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_Horario_Inicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Horario_Final = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciudades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abreviatura = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modalidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Num_Documento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo_Documento = table.Column<int>(type: "int", nullable: false),
                    Genero = table.Column<int>(type: "int", nullable: false),
                    Ciudad = table.Column<int>(type: "int", nullable: false),
                    Perfil = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ramas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ramas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tipos_Documentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abreviatura = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipos_Documentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cancha",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cantidad_Canchas = table.Column<int>(type: "int", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    campoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cancha", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cancha_Campos_campoId",
                        column: x => x.campoId,
                        principalTable: "Campos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Arbitros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Certificado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arbitros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arbitros_Personas_personaId",
                        column: x => x.personaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Campeonatos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha_Inicial = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fecha_Fin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reglamento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Eliminatorias = table.Column<int>(type: "int", nullable: false),
                    Numero_Equipos_Premiados = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Equipos = table.Column<int>(type: "int", nullable: false),
                    arbitroId = table.Column<int>(type: "int", nullable: true),
                    canchaId = table.Column<int>(type: "int", nullable: true),
                    categoriaId = table.Column<int>(type: "int", nullable: true),
                    modalidadId = table.Column<int>(type: "int", nullable: true),
                    ramaId = table.Column<int>(type: "int", nullable: true),
                    equipoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campeonatos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campeonatos_Arbitros_arbitroId",
                        column: x => x.arbitroId,
                        principalTable: "Arbitros",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Campeonatos_Cancha_canchaId",
                        column: x => x.canchaId,
                        principalTable: "Cancha",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Campeonatos_Categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Campeonatos_Modalidades_modalidadId",
                        column: x => x.modalidadId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Campeonatos_Ramas_ramaId",
                        column: x => x.ramaId,
                        principalTable: "Ramas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Peso = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    personaId = table.Column<int>(type: "int", nullable: true),
                    campeonatoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jugadores_Campeonatos_campeonatoId",
                        column: x => x.campeonatoId,
                        principalTable: "Campeonatos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Jugadores_Personas_personaId",
                        column: x => x.personaId,
                        principalTable: "Personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_Jugadores = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color_Uniforme_Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Color_Uniforme_Visitante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contacto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    categoriaId = table.Column<int>(type: "int", nullable: true),
                    modalidadId = table.Column<int>(type: "int", nullable: true),
                    ramaId = table.Column<int>(type: "int", nullable: true),
                    ciudadId = table.Column<int>(type: "int", nullable: true),
                    jugadorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipos_Categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Ciudades_ciudadId",
                        column: x => x.ciudadId,
                        principalTable: "Ciudades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Jugadores_jugadorId",
                        column: x => x.jugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Modalidades_modalidadId",
                        column: x => x.modalidadId,
                        principalTable: "Modalidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipos_Ramas_ramaId",
                        column: x => x.ramaId,
                        principalTable: "Ramas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipo_Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Dorsal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Abreviatura_Posicion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipoId = table.Column<int>(type: "int", nullable: true),
                    jugadorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipo_Jugadores_Equipos_equipoId",
                        column: x => x.equipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipo_Jugadores_Jugadores_jugadorId",
                        column: x => x.jugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipoId = table.Column<int>(type: "int", nullable: true),
                    arbitroId = table.Column<int>(type: "int", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "Equipo_Partidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Equipo_Local = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Equipo_Visitante = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    equipoId = table.Column<int>(type: "int", nullable: true),
                    partidoId = table.Column<int>(type: "int", nullable: true),
                    campoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo_Partidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipo_Partidos_Campos_campoId",
                        column: x => x.campoId,
                        principalTable: "Campos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipo_Partidos_Equipos_equipoId",
                        column: x => x.equipoId,
                        principalTable: "Equipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Equipo_Partidos_Partido_partidoId",
                        column: x => x.partidoId,
                        principalTable: "Partido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Partido_Jugadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gol = table.Column<int>(type: "int", nullable: false),
                    Falta = table.Column<int>(type: "int", nullable: false),
                    Tarjeta_Roja = table.Column<int>(type: "int", nullable: false),
                    Tarjeta_Amarilla = table.Column<int>(type: "int", nullable: false),
                    Tarjeta_Azul = table.Column<int>(type: "int", nullable: false),
                    Autogol = table.Column<int>(type: "int", nullable: false),
                    Minuto = table.Column<DateTime>(type: "datetime2", nullable: false),
                    partidoId = table.Column<int>(type: "int", nullable: true),
                    jugadorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido_Jugadores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partido_Jugadores_Jugadores_jugadorId",
                        column: x => x.jugadorId,
                        principalTable: "Jugadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Partido_Jugadores_Partido_partidoId",
                        column: x => x.partidoId,
                        principalTable: "Partido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arbitros_personaId",
                table: "Arbitros",
                column: "personaId");

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
                name: "IX_Cancha_campoId",
                table: "Cancha",
                column: "campoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_Jugadores_equipoId",
                table: "Equipo_Jugadores",
                column: "equipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_Jugadores_jugadorId",
                table: "Equipo_Jugadores",
                column: "jugadorId");

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
                name: "IX_Jugadores_campeonatoId",
                table: "Jugadores",
                column: "campeonatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_personaId",
                table: "Jugadores",
                column: "personaId");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_arbitroId",
                table: "Partido",
                column: "arbitroId");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_equipoId",
                table: "Partido",
                column: "equipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_Jugadores_jugadorId",
                table: "Partido_Jugadores",
                column: "jugadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Partido_Jugadores_partidoId",
                table: "Partido_Jugadores",
                column: "partidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Campeonatos_Equipos_equipoId",
                table: "Campeonatos",
                column: "equipoId",
                principalTable: "Equipos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arbitros_Personas_personaId",
                table: "Arbitros");

            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Personas_personaId",
                table: "Jugadores");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Arbitros_arbitroId",
                table: "Campeonatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Cancha_canchaId",
                table: "Campeonatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Categorias_categoriaId",
                table: "Campeonatos");

            migrationBuilder.DropForeignKey(
                name: "FK_Equipos_Categorias_categoriaId",
                table: "Equipos");

            migrationBuilder.DropForeignKey(
                name: "FK_Campeonatos_Equipos_equipoId",
                table: "Campeonatos");

            migrationBuilder.DropTable(
                name: "Equipo_Jugadores");

            migrationBuilder.DropTable(
                name: "Equipo_Partidos");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Partido_Jugadores");

            migrationBuilder.DropTable(
                name: "Perfiles");

            migrationBuilder.DropTable(
                name: "Tipos_Documentos");

            migrationBuilder.DropTable(
                name: "Partido");

            migrationBuilder.DropTable(
                name: "Personas");

            migrationBuilder.DropTable(
                name: "Arbitros");

            migrationBuilder.DropTable(
                name: "Cancha");

            migrationBuilder.DropTable(
                name: "Campos");

            migrationBuilder.DropTable(
                name: "Categorias");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropTable(
                name: "Ciudades");

            migrationBuilder.DropTable(
                name: "Jugadores");

            migrationBuilder.DropTable(
                name: "Campeonatos");

            migrationBuilder.DropTable(
                name: "Modalidades");

            migrationBuilder.DropTable(
                name: "Ramas");
        }
    }
}
