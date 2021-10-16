using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

using SoccerManager.App.Dominio;
using SoccerManager.App.Persistencia;

namespace SoccerManager.App.Presentacion
{
    public class ListPersonaModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Persona> personas { get; set; }
        public string searchString; 
        public ListPersonaModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            personas = _appContext.GetAllPersonas(searchString);
        }
        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            personas = _appContext.GetAllPersonas(searchString);
            return Page();
        }
    }
}
