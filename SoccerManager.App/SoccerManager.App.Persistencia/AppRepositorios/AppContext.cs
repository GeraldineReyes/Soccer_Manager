using System;
using Microsoft.EntityFrameworkCore;
using SoccerManager.App.Dominio;

namespace SoccerManager.App.Persistencia
{
    public class AppContext : DbContext
    {
        
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Campo> Campos { get; set; }
        public DbSet<Tipo_Documento> Tipos_Documentos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Perfil> Perfiles { get; set; }
<<<<<<< Updated upstream
        public DbSet<Rama> Ramas { get; set; }
        public DbSet<Modalidad> Modalidades { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Arbitro> Arbitros { get; set; }
        public DbSet<Campeonato> Campeonatos { get; set; }
        public DbSet<Equipo_Jugador> Equipo_Jugadores { get; set; }
        public DbSet<Equipo_Partido> Equipo_Partidos { get; set; }
        public DbSet<Equipo> Equipos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Partido_Jugador> Partido_Jugadores { get; set; }
=======
        public DbSet<Cancha> Canchas { get; set; }
>>>>>>> Stashed changes

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SoccerManager");
        }
    }
    }
}