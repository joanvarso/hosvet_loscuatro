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
    public class CrearModel : PageModel
    {
      private readonly IRepositorioMascota _repositorioMascota;
      public Mascota mascota {get; set;}
      public CrearModel (IRepositorioMascota _repositorioMascota)
      {
        this._repositorioMascota = _repositorioMascota;
      }
        public void OnGet()
        {
          mascota = new Mascota();
        }
        public IActionResult OnPost(Mascota mascota)
        {
          _repositorioMascota.AgregarMascota(mascota);
          return RedirectToPage("Index");
          
        }
    }
}
