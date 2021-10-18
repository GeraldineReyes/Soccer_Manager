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
    public class EditModalidadModel : PageModel
    {
        private readonly IRepositorios _appContext;

        [BindProperty]
        public Modalidad modalidad  { get; set; } 

        public EditModalidadModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? modalidadId)
        {
            if (modalidadId.HasValue)
            {
                modalidad = _appContext.GetModalidad(modalidadId.Value);
            }
            else
            {
                modalidad = new Modalidad();
            }
            if (modalidad == null)
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
            if(modalidad.Id > 0)
            {
               modalidad = _appContext.UpdateModalidad(modalidad);
            }
            else
            {
               _appContext.AddModalidad(modalidad);
            }
            return Page();
        }
    }
}
