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
    public class EditPersonaModel : PageModel
    {
       private readonly IRepositorios _appContext;

        [BindProperty]
        public Persona persona  { get; set; } 
        public IEnumerable<Tipo_Documento> tipos_documentos {get; set;} 
        public IEnumerable<Genero> generos {get; set;} 
        public IEnumerable<Ciudad> ciudades {get; set;} 
        public IEnumerable<Perfil> perfiles {get; set;} 
        public string searchString;
        public string searchTipo_Documento;
        public string searchGenero;
        public string searchCiudad;
        public string searchPerfil;

        public EditPersonaModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? personaId)
        {                           
            tipos_documentos =_appContext.GetAllTipos_Documentos(searchTipo_Documento);
            generos =_appContext.GetAllGeneros(searchGenero);
            ciudades =_appContext.GetAllCiudades(searchCiudad);
            perfiles =_appContext.GetAllPerfiles(searchPerfil);
            if (personaId.HasValue)
            {
                persona = _appContext.GetPersona(personaId.Value);
            }
            else
            {
                persona = new Persona(); 
            }

            if (persona == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            tipos_documentos =_appContext.GetAllTipos_Documentos(searchTipo_Documento);
            generos =_appContext.GetAllGeneros(searchGenero);
            ciudades =_appContext.GetAllCiudades(searchCiudad);
            perfiles =_appContext.GetAllPerfiles(searchPerfil);
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(persona.Id > 0)
            {
               persona = _appContext.UpdatePersona(persona);
            }
            else
            {
               _appContext.AddPersona(persona);
            }
            return Page();
        }
    }
}

