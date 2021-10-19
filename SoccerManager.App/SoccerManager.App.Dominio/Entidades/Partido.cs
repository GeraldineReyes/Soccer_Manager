using System;
namespace SoccerManager.App.Dominio
{
    public class Partido
    {
        public int Id { get; set; }        
        public string Estado { get; set;}

        public  Equipo equipo { get; set; }
        public  Arbitro  arbitro { get; set;}
        
    }
}