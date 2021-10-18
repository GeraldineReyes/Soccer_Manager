using System;
namespace SoccerManager.App.Dominio
{
    public class Campeonato_Equipo
    {
       public int Id { get; set; }
       public int Valor_Inscripcion { get; set; }

       public int Campeonato  { get; set; }
       public int Equipo  { get; set; }
    }
}