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
    public class ListPerfilModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Perfil> perfiles { get; set; }
        public string searchString; 
        public ListPerfilModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            perfiles = _appContext.GetAllPerfiles(searchString);
        }
        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            perfiles = _appContext.GetAllPerfiles(searchString);
            return Page();
        }
    }
}
