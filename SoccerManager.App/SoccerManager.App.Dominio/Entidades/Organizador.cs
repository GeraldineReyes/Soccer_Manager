using System;
namespace SoccerManager.App.Dominio

{
    public class Organizador
    {
        public int Id { get; set; }
        
        public  Persona persona { get; set; }
        public  Campeonato campeonato { get; set; }
    }
}