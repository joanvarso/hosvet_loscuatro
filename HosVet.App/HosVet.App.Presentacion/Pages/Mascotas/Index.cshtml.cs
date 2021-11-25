using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HosVet.App.Dominio;
using HosVet.App.Persistencia;

namespace HospiEnCasa.App.Presentacion.Pages.Mascotas
{
    public class IndexModel : PageModel
    {
      //Creando un campo de lectura para el interfaz CRUD de la entidad Mascota
      private readonly IRepositorioMascota _repositorioMascota;
      public IEnumerable<Mascota> Mascotas {get; set;}
      public IndexModel(IRepositorioMascota _repositorioMascota)
      {
        this._repositorioMascota = _repositorioMascota;
      }
        public void OnGet()
        {
          Mascotas = _repositorioMascota.ObtenerTodasLasMascota();
        }
    }
}
