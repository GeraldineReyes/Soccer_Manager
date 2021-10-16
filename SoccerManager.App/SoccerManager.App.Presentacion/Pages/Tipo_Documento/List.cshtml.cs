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
    public class ListTipo_DocumentoModel : PageModel
    {
        private readonly IRepositorios _appContext;
        public IEnumerable<Tipo_Documento> tipos_documentos { get; set; }
        public string searchString;
        public ListTipo_DocumentoModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
            tipos_documentos = _appContext.GetAllTipos_Documentos(searchString);
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            tipos_documentos = _appContext.GetAllTipos_Documentos(searchString);
            return Page();
        }
    }
}
