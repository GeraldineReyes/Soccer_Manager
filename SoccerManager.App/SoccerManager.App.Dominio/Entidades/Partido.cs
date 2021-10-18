using System;
namespace SoccerManager.App.Dominio
{
    public class Partido
    {
        public int Id { get; set; }        
        public string Estado { get; set;}

        public int Equipo  { get; set; }
        public int Arbitro  { get; set;}
        
    }
}