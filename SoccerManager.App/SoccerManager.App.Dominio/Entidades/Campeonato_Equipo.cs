using System;
namespace SoccerManager.App.Dominio
{
    public class Campeonato_Equipo
    {
       public int Id { get; set; }
       public int Valor_Inscripcion { get; set; }

       public  Campeonato  campeonato { get; set; }
       public  Equipo equipo { get; set; }
    }
}