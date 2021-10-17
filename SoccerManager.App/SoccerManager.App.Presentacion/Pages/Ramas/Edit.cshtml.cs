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
    public class EditModel : PageModel
    {
        private readonly IRepositorios _appContext;

        [BindProperty]
        public Rama rama  { get; set; } 

        public EditModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? ramaId)
        {
            if (ramaId.HasValue)
            {
                rama = _appContext.GetRama(ramaId.Value);
            }
            else
            {
                rama = new Rama();
            }
            if (rama == null)
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
            if(rama.Id > 0)
            {
               rama = _appContext.UpdateRama(rama);
            }
            else
            {
               _appContext.AddRama(rama);
            }
            return Page();
        }
    }
}
