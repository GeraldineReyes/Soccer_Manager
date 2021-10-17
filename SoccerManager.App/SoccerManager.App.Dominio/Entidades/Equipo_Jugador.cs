using System;
namespace SoccerManager.App.Dominio
{
    public class Equipo_Jugador
    {

        public int Id { get; set; }


        public string Dorsal { get; set; }
        public string Posicion { get; set; }
        public string Abreviatura_Posicion { get; set; }

        public Equipo equipo { get; set; }
        public Jugador jugador { get; set;}

    }
}