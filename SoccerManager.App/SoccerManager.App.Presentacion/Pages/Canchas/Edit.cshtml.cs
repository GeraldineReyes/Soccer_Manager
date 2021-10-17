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
    public class EditCanchaModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Cancha cancha  { get; set; } 
        public IEnumerable<Campo> campos {get; set;} 
        
        public string searchString;
        public string searchCampo;
        

        public EditCanchaModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? canchaId)
        {                           
            campos =_appContext.GetAllCampos(searchCampo);
            
            if (canchaId.HasValue)
            {
                cancha = _appContext.GetCancha(canchaId.Value);
            }
            else
            {
                cancha = new Cancha(); 
            }

            if (cancha == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            campos =_appContext.GetAllCampos(searchCampo);
            
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(cancha.Id > 0)
            {
               cancha = _appContext.UpdateCancha(cancha);
            }
            else
            {
               _appContext.AddCancha(cancha);
            }
            return Page();
        }
    }
}

