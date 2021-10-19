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

        public  Categoria categoria { get; set; }
        public  Modalidad  modalidad { get; set; }
        public  Rama rama { get; set;}
        public  Ciudad ciudad { get; set; }
        public  Jugador jugador { get; set; } 
        
    }
}