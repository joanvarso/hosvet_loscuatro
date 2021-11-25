using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using  HosVet.App.Dominio;
using  HosVet.App.Persistencia;

namespace HosVet.App.Presentacion.Pages.SignoVitales
{
    public class EliminarModel : PageModel
    {
      private readonly IRepositorioSignoVital _repositorioSignoVital;
      public SignoVital signoVital {get; set; }

      public EliminarModel (IRepositorioSignoVital _repositorioSignoVital){
        this._repositorioSignoVital = _repositorioSignoVital;
      }
        public IActionResult OnGet(int id)
        {
          _repositorioSignoVital.BorrarSignoVital(id);
          return RedirectToPage("Index");

        }
    }
}
