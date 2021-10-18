using System;
//using System.DataTime;
namespace SoccerManager.App.Dominio
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Altura { get; set; }
        public string Peso { get; set;}

        public  Persona  persona { get; set; }
        public  Campeonato campeonato { get; set;}
        

    }
}