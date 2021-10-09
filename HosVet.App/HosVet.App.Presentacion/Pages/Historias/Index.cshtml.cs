using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HosVet.App.Persistencia;
using HosVet.App.Dominio;

namespace HosVet.App.Presentacion.Pages.Historias
{
    public class IndexModel : PageModel
    {
      private readonly IRepositorioHistoria _repositorioHistoria;
      public IEnumerable<Historia> Historias {get; set;}
      public IndexModel (IRepositorioHistoria _repositorioHistoria)
      {
          this._repositorioHistoria = _repositorioHistoria;
      }
        public void OnGet()
        {
          Historias = _repositorioHistoria.ObtenerTodasLasHistorias();
        }
    }
}
