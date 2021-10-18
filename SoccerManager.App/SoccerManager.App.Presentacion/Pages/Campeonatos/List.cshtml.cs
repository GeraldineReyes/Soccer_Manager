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
    public class ListCampeonatoModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Campeonato> campeonatos { get; set; }
        public string searchString; 
        public ListCampeonatoModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            campeonatos = _appContext.GetAllCampeonatos(searchString);
        }
        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
             campeonatos = _appContext.GetAllCampeonatos(searchString);
            return Page();
        }
    }
}

