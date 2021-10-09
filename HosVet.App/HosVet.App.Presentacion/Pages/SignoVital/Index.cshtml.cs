using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HosVet.App.Persitencia;
using HosVet.App.Dominio;

namespace HosVet.App.Presentacion.Pages
{
    public class IndexModel : PageModel
    {
      private readonly IRepositorioSignoVital _repositorioSignoVital;
      public IEnumerable<SignoVital> SignoVitales {get; set;}
      public IndexModel(IRepositorioSignoVital _repositorioSignoVital)
      {
        this._repositorioSignoVital = _repositorioSignoVital;
      }
        public void OnGet()
        {
          SignoVitales = _repositorioSignoVital.ObtenerTodosLosSignoVital();
        }
    }
}
