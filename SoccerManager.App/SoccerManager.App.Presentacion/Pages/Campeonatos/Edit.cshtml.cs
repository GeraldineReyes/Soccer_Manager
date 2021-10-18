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
    public class EditCampeonatoModel : PageModel
    {
         private readonly IRepositorios _appContext;

        [BindProperty]
        public Campeonato campeonato  { get; set; } 
        public IEnumerable<Arbitro> arbitros {get; set;}
        public IEnumerable<Cancha> canchas  {get; set;}
        public IEnumerable<Categoria> categorias {get; set;}
        public IEnumerable<Modalidad> modalidades {get; set;}
        public IEnumerable<Rama> ramas {get; set;}
        public IEnumerable<Equipo> equipos {get; set;} 
        
        public string searchCampo;
        public string searchArbitro;
        public string searchCancha;
        public string searchCategoria;
        public string searchModalidad;
        public string searchRama;
        public string searchEquipo;
        public EditCampeonatoModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
       public IActionResult OnGet(int? campeonatoId)
        {                           
           
//           arbitros =_appContext.GetAllArbitros(searchArbitro);
            canchas =_appContext.GetAllCanchas(searchCancha);
            categorias =_appContext.GetAllCategorias(searchCategoria);
            modalidades =_appContext.GetAllModalidades(searchModalidad);
            ramas =_appContext.GetAllRamas(searchRama);
            equipos =_appContext.GetAllEquipos(searchEquipo);


            if (campeonatoId.HasValue)
            {
                campeonato = _appContext.GetCampeonato(campeonatoId.Value);
            }
            else
            {
                campeonato = new Campeonato(); 
            }

            if (campeonato == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
//           arbitros =_appContext.GetAllArbitros(searchArbitro);
            canchas =_appContext.GetAllCanchas(searchCancha);
            categorias =_appContext.GetAllCategorias(searchCategoria);
            modalidades =_appContext.GetAllModalidades(searchModalidad);
            ramas =_appContext.GetAllRamas(searchRama);
            equipos =_appContext.GetAllEquipos(searchEquipo);
            
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(campeonato.Id > 0)
            {
               campeonato = _appContext.UpdateCampeonato(campeonato);
            }
            else
            {
               _appContext.AddCampeonato(campeonato);
            }
            return Page();
        }
    }
}