using System;
namespace SoccerManager.App.Dominio
{
    public class Equipo_Jugador
    {

        public int Id { get; set; }


        public string Dorsal { get; set; }
        public string Posicion { get; set; }
        public string Abreviatura_Posicion { get; set; }

        public int Equipo  { get; set; }
        public int Jugador  { get; set;}

    }
}