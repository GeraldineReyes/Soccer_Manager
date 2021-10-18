using System;
namespace SoccerManager.App.Dominio
{
    public class Equipo_Partido
    {
        public int Id { get; set; }
        public string Equipo_Local { get; set; }
        public string Equipo_Visitante { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }

        public int Equipo  { get; set; }
        public int Partido  { get; set; }
        public int Campo  { get; set; }

    }
}