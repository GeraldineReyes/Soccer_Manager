using System;
namespace SoccerManager.App.Dominio
{
    public class Equipo
    {
        public int Id {get; set; }
        public string Nombre {get; set; }
        public int Numero_Jugadores {get; set;}
        public string Estado {get; set; }
        public string Color_Uniforme_Local {get; set; }   
        public string Color_Uniforme_Visitante {get; set; }
        public string Contacto {get; set; }
        public string Telefono {get; set; }
        public string Email {get; set; }

        public int Categoria  { get; set; }
        public int Modalidad  { get; set; }
        public int Rama  { get; set;}
        public int Ciudad  { get; set; }
        public int Jugador  { get; set; } 
        
    }
}