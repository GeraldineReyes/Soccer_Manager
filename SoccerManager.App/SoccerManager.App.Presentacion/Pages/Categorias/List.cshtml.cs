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
    public class ListCategoriaModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Categoria> categorias { get; set; }
        public string searchString; 
        public ListCategoriaModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            categorias = _appContext.GetAllCategorias(searchString);
        }
        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            categorias = _appContext.GetAllCategorias(searchString);
            return Page();
        }
    }
}
