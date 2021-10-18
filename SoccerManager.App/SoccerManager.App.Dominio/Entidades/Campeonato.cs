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

        public  Arbitro arbitro  { get; set; }
        public  Cancha cancha  { get; set; }
        public  Categoria categoria  { get; set; }
        public  Modalidad  modalidad { get; set; }
        public  Rama rama { get; set; }
        public  Equipo equipo  { get; set; }
    }
}