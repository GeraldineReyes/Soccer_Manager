using System;
namespace SoccerManager.App.Dominio
{
    public class Partido_Jugador
    {
        public int Id { get; set; }
        public int Gol { get; set;}
        public int Falta { get; set;} 
        public int Tarjeta_Roja { get; set; }       
        public int Tarjeta_Amarilla { get; set; }
        public int Tarjeta_Azul { get; set;}
        public int Autogol { get; set; }
        public DateTime Minuto { get; set; }


        public int Partido  { get; set; }
        public int Jugador  { get; set; }


    }
}