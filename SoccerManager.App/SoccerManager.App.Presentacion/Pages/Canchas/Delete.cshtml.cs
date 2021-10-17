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
    public class DeleteCanchaModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Cancha cancha  { get; set; } 

        public DeleteCanchaModel()
        {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int canchaId)
        {
            cancha = _appContext.GetCancha(canchaId);
            if(cancha == null)
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
            if(cancha.Id > 0)
            {
               _appContext.DeleteCancha(cancha.Id);
            }
            return Page();
        }
    }
}


