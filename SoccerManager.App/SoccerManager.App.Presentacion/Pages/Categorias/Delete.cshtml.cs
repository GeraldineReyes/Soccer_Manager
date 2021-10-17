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
    public class DeleteCategoriaModel : PageModel
    {
        private readonly IRepositorios _appContext;

        [BindProperty]
        public Categoria categoria  { get; set; } 

        public DeleteCategoriaModel()
        {
            this._appContext  =new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
     
        //se ejecuta al presionar Eliminar en la lista
        public IActionResult OnGet(int categoriaId)
        {
            categoria = _appContext.GetCategoria(categoriaId);
            if(categoria == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();

        }
        
        //se ejecuta al presionar Eliminar en el formulario 
        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(categoria.Id > 0)
            {
               _appContext.DeleteCategoria(categoria.Id);
            }
            return Page();
        }
    }
}
