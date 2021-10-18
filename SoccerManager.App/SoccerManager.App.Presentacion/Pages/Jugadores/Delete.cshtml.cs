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
    public class DeleteJugadorModel : PageModel
    {
        
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Jugador jugador  { get; set; } 

        public DeleteJugadorModel()
        {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int jugadorId)
        {
            jugador = _appContext.GetJugador(jugadorId);
            if(jugador == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
        
        //se ejecuta al presionar Eliminar en el formulario 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(jugador.Id > 0)
            {
               _appContext.DeleteJugador(jugador.Id);
            }
            return Page();
        }
    }
}
