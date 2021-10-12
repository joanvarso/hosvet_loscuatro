using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HosVet.App.Dominio;
using HosVet.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HosVet.App.Presentacion.Pages.Auxiliares
{
    

    public class IndexModel : PageModel
    {
        public readonly IRepositorioAuxiliarVeterinario _repoAuxiliarVeterinario;
        public IEnumerable<AuxiliarVeterinario> auxiliarVeterinario {get;set;}
        public IndexModel (IRepositorioAuxiliarVeterinario _repoAuxiliarVeterinario)
        {
            this._repoAuxiliarVeterinario=_repoAuxiliarVeterinario;
        }
        public void OnGet()
        {
            auxiliarVeterinario=_repoAuxiliarVeterinario.ObtenerTodosLosAuxiliarVeterinarios();
        }
    }
}
 