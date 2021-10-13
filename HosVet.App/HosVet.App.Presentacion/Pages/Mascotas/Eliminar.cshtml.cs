using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using HosVet.App.Dominio;
using HosVet.App.Persistencia;
namespace HosVet.App.Presentacion.Pages.Mascotas
{
  private readonly IRepositorioMascota _repositorioMascota;
  public Mascota mascota;

    public class EliminarModel : PageModel
    {
      public EliminarModel(IRepositorioMascota _repositorioMascota)
      {
          this._repositorioMascota = _repositorioMascota;
      }
        public void OnGet(int id)
        {
          mascota = _repositorioMascota.BorrarMascota(id);
        }
    }
}
