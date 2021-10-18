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
    public class ListAdminModel : PageModel
    {
        private readonly IRepositorios _appContext;
        
        public string searchString; 
        public ListAdminModel()
        {
            this._appContext = new Repositorios(new SoccerManager.App.Persistencia.AppContext());
        }
        
}
}
