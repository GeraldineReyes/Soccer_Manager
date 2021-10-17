using System;
namespace SoccerManager.App.Dominio
{
    public class Cancha
    {
        public int Id { get; set; }
        public string Nombre { get; set;}
        public int Cantidad_Canchas { get; set; }
        public string Direccion { get; set;}
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Contacto { get; set; }

        public int Campo { get; set; }           
    }
}