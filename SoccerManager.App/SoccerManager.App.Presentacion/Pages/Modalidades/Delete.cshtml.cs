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
    public class DeleteModalidadModel : PageModel
    {
        private readonly IRepositorios _appContext;

        [BindProperty]
        public Modalidad modalidad  { get; set; } 

        public DeleteModalidadModel()
        {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int modalidadId)
        {
            modalidad = _appContext.GetModalidad(modalidadId);
            if(modalidad == null)
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
            if(modalidad.Id > 0)
            {
               _appContext.DeleteModalidad(modalidad.Id);
            }
            return Page();
        }
    }
}
