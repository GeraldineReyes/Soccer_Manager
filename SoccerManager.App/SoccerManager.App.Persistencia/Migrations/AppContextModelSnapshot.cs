﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoccerManager.App.Persistencia;

namespace SoccerManager.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("SoccerManager.App.Dominio.Arbitro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Certificado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("personaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("personaId");

                    b.ToTable("Arbitros");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Campeonato", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Fin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Inicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero_Eliminatorias")
                        .HasColumnType("int");

                    b.Property<int>("Numero_Equipos")
                        .HasColumnType("int");

                    b.Property<int>("Numero_Equipos_Premiados")
                        .HasColumnType("int");

                    b.Property<string>("Reglamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("arbitroId")
                        .HasColumnType("int");

                    b.Property<int?>("canchaId")
                        .HasColumnType("int");

                    b.Property<int?>("categoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("equipoId")
                        .HasColumnType("int");

                    b.Property<int?>("modalidadId")
                        .HasColumnType("int");

                    b.Property<int?>("ramaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("arbitroId");

                    b.HasIndex("canchaId");

                    b.HasIndex("categoriaId");

                    b.HasIndex("equipoId");

                    b.HasIndex("modalidadId");

                    b.HasIndex("ramaId");

                    b.ToTable("Campeonatos");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Campo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Fecha_Horario_Final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Fecha_Horario_Inicial")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Campos");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Cancha", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Campo")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad_Canchas")
                        .HasColumnType("int");

                    b.Property<string>("Contacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Canchas");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ciudades");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Color_Uniforme_Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color_Uniforme_Visitante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contacto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero_Jugadores")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("categoriaId")
                        .HasColumnType("int");

                    b.Property<int?>("ciudadId")
                        .HasColumnType("int");

                    b.Property<int?>("jugadorId")
                        .HasColumnType("int");

                    b.Property<int?>("modalidadId")
                        .HasColumnType("int");

                    b.Property<int?>("ramaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("categoriaId");

                    b.HasIndex("ciudadId");

                    b.HasIndex("jugadorId");

                    b.HasIndex("modalidadId");

                    b.HasIndex("ramaId");

                    b.ToTable("Equipos");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Equipo_Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Abreviatura_Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Dorsal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("equipoId")
                        .HasColumnType("int");

                    b.Property<int?>("jugadorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("equipoId");

                    b.HasIndex("jugadorId");

                    b.ToTable("Equipo_Jugadores");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Equipo_Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Equipo_Local")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Equipo_Visitante")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int?>("campoId")
                        .HasColumnType("int");

                    b.Property<int?>("equipoId")
                        .HasColumnType("int");

                    b.Property<int?>("partidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("campoId");

                    b.HasIndex("equipoId");

                    b.HasIndex("partidoId");

                    b.ToTable("Equipo_Partidos");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Abreviatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Altura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Peso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("campeonatoId")
                        .HasColumnType("int");

                    b.Property<int?>("personaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("campeonatoId");

                    b.HasIndex("personaId");

                    b.ToTable("Jugadores");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Modalidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Modalidades");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Partido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("arbitroId")
                        .HasColumnType("int");

                    b.Property<int?>("equipoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("arbitroId");

                    b.HasIndex("equipoId");

                    b.ToTable("Partido");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Partido_Jugador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("Autogol")
                        .HasColumnType("int");

                    b.Property<int>("Falta")
                        .HasColumnType("int");

                    b.Property<int>("Gol")
                        .HasColumnType("int");

                    b.Property<DateTime>("Minuto")
                        .HasColumnType("datetime2");

                    b.Property<int>("Tarjeta_Amarilla")
                        .HasColumnType("int");

                    b.Property<int>("Tarjeta_Azul")
                        .HasColumnType("int");

                    b.Property<int>("Tarjeta_Roja")
                        .HasColumnType("int");

                    b.Property<int?>("jugadorId")
                        .HasColumnType("int");

                    b.Property<int?>("partidoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("jugadorId");

                    b.HasIndex("partidoId");

                    b.ToTable("Partido_Jugadores");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Perfiles");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Ciudad")
                        .HasColumnType("int");

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Fecha_Nacimiento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Num_Documento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tipo_Documento")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Personas");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Rama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ramas");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Tipo_Documento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Abreviatura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tipos_Documentos");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Arbitro", b =>
                {
                    b.HasOne("SoccerManager.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaId");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Campeonato", b =>
                {
                    b.HasOne("SoccerManager.App.Dominio.Arbitro", "arbitro")
                        .WithMany()
                        .HasForeignKey("arbitroId");

                    b.HasOne("SoccerManager.App.Dominio.Cancha", "cancha")
                        .WithMany()
                        .HasForeignKey("canchaId");

                    b.HasOne("SoccerManager.App.Dominio.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaId");

                    b.HasOne("SoccerManager.App.Dominio.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("equipoId");

                    b.HasOne("SoccerManager.App.Dominio.Modalidad", "modalidad")
                        .WithMany()
                        .HasForeignKey("modalidadId");

                    b.HasOne("SoccerManager.App.Dominio.Rama", "rama")
                        .WithMany()
                        .HasForeignKey("ramaId");

                    b.Navigation("arbitro");

                    b.Navigation("cancha");

                    b.Navigation("categoria");

                    b.Navigation("equipo");

                    b.Navigation("modalidad");

                    b.Navigation("rama");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Equipo", b =>
                {
                    b.HasOne("SoccerManager.App.Dominio.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaId");

                    b.HasOne("SoccerManager.App.Dominio.Ciudad", "ciudad")
                        .WithMany()
                        .HasForeignKey("ciudadId");

                    b.HasOne("SoccerManager.App.Dominio.Jugador", "jugador")
                        .WithMany()
                        .HasForeignKey("jugadorId");

                    b.HasOne("SoccerManager.App.Dominio.Modalidad", "modalidad")
                        .WithMany()
                        .HasForeignKey("modalidadId");

                    b.HasOne("SoccerManager.App.Dominio.Rama", "rama")
                        .WithMany()
                        .HasForeignKey("ramaId");

                    b.Navigation("categoria");

                    b.Navigation("ciudad");

                    b.Navigation("jugador");

                    b.Navigation("modalidad");

                    b.Navigation("rama");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Equipo_Jugador", b =>
                {
                    b.HasOne("SoccerManager.App.Dominio.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("equipoId");

                    b.HasOne("SoccerManager.App.Dominio.Jugador", "jugador")
                        .WithMany()
                        .HasForeignKey("jugadorId");

                    b.Navigation("equipo");

                    b.Navigation("jugador");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Equipo_Partido", b =>
                {
                    b.HasOne("SoccerManager.App.Dominio.Campo", "campo")
                        .WithMany()
                        .HasForeignKey("campoId");

                    b.HasOne("SoccerManager.App.Dominio.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("equipoId");

                    b.HasOne("SoccerManager.App.Dominio.Partido", "partido")
                        .WithMany()
                        .HasForeignKey("partidoId");

                    b.Navigation("campo");

                    b.Navigation("equipo");

                    b.Navigation("partido");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Jugador", b =>
                {
                    b.HasOne("SoccerManager.App.Dominio.Campeonato", "campeonato")
                        .WithMany()
                        .HasForeignKey("campeonatoId");

                    b.HasOne("SoccerManager.App.Dominio.Persona", "persona")
                        .WithMany()
                        .HasForeignKey("personaId");

                    b.Navigation("campeonato");

                    b.Navigation("persona");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Partido", b =>
                {
                    b.HasOne("SoccerManager.App.Dominio.Arbitro", "arbitro")
                        .WithMany()
                        .HasForeignKey("arbitroId");

                    b.HasOne("SoccerManager.App.Dominio.Equipo", "equipo")
                        .WithMany()
                        .HasForeignKey("equipoId");

                    b.Navigation("arbitro");

                    b.Navigation("equipo");
                });

            modelBuilder.Entity("SoccerManager.App.Dominio.Partido_Jugador", b =>
                {
                    b.HasOne("SoccerManager.App.Dominio.Jugador", "jugador")
                        .WithMany()
                        .HasForeignKey("jugadorId");

                    b.HasOne("SoccerManager.App.Dominio.Partido", "partido")
                        .WithMany()
                        .HasForeignKey("partidoId");

                    b.Navigation("jugador");

                    b.Navigation("partido");
                });
#pragma warning restore 612, 618
        }
    }
}
