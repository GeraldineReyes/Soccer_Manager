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
    public class EditJugadorModel : PageModel
    {
              private readonly IRepositorios _appContext;

        [BindProperty]
        public Jugador jugador  { get; set; } 

        public EditJugadorModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? jugadorId)
        {
            if (jugadorId.HasValue)
            {
                jugador = _appContext.GetJugador(jugadorId.Value);
            }
            else
            {
                jugador = new Jugador();
            }
            if (jugador == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(jugador.Id > 0)
            {
               jugador = _appContext.UpdateJugador(jugador);
            }
            else
            {
               _appContext.AddJugador(jugador);
            }
            return Page();
        }
    }
}
