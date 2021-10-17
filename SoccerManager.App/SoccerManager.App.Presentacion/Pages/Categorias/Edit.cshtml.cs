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
    public class EditCategoriaModel : PageModel
    {
        private readonly IRepositorios _appContext;

        [BindProperty]
        public Categoria categoria  { get; set; } 

        public EditCategoriaModel()
       {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
       }
     

        public IActionResult OnGet(int? categoriaId)
        {
            if (categoriaId.HasValue)
            {
                categoria = _appContext.GetCategoria(categoriaId.Value);
            }
            else
            {
                categoria = new Categoria();
            }
            if (categoria == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(categoria.Id > 0)
            {
               categoria = _appContext.UpdateCategoria(categoria);
            }
            else
            {
               _appContext.AddCategoria(categoria);
            }
            return Page();
        }
    }
}
