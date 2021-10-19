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

        public  Equipo equipo  { get; set; }
        public  Partido partido { get; set; }
        public  Campo campo { get; set; }

    }
}