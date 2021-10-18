using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using SoccerManager.App.Dominio;
using SoccerManager.App.Persistencia;

namespace SoccerManager.App.Presentacion
{
    public class ListJugadorModel : PageModel
    {
        

        private readonly IRepositorios _appContext;
        public IEnumerable<Jugador> jugadores { get; set; }
        public string searchString; 
        public ListJugadorModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            jugadores = _appContext.GetAllJugadores(searchString);
        }
        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            jugadores = _appContext.GetAllJugadores(searchString);
            return Page();
        }
    }
}
