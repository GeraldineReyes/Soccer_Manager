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
    public class ListModalidadModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Modalidad> modalidades { get; set; }
        public string searchString; 
        public ListModalidadModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            modalidades = _appContext.GetAllModalidades(searchString);
        }
        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            modalidades = _appContext.GetAllModalidades(searchString);
            return Page();
        }
    }
}
