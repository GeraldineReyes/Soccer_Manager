using System;
//using System.DataTime;
namespace SoccerManager.App.Dominio
{
    public class Campeonato
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public DateTime Fecha_Inicial { get; set;}
        public DateTime Fecha_Fin { get; set;}
        public string Reglamento { get; set;}
        public int  Numero_Eliminatorias { get; set;}
        public int Numero_Equipos_Premiados { get; set;}
        public string Estado { get; set;}
        public int Numero_Equipos { get; set;}

        public int Arbitro  { get; set; }
        public int Cancha  { get; set; }
        public int Categoria  { get; set; }
        public int Modalidad  { get; set; }
        public int Rama  { get; set; }
        public int Equipo  { get; set; }
    }
}