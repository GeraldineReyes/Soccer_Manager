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
    public class ListCanchaModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Cancha> canchas { get; set; }
        public string searchString; 
        public ListCanchaModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            canchas = _appContext.GetAllCanchas(searchString);
        }
        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            canchas = _appContext.GetAllCanchas(searchString);
            return Page();
        }
    }
}
