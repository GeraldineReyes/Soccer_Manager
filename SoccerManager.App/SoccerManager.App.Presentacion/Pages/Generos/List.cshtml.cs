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
    public class ListGeneroModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Genero> generos { get; set; }
        public string searchString; 
        public ListGeneroModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            generos = _appContext.GetAllGeneros(searchString);
        }
        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            generos = _appContext.GetAllGeneros(searchString);
            return Page();
        }
    }
}
