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
    public class ListModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Rama> ramas { get; set; }
        public string searchString; 
        public ListModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            ramas = _appContext.GetAllRamas(searchString);
        }
        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            ramas = _appContext.GetAllRamas(searchString);
            return Page();
        }
    }
}
