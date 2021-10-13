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
    public class SignovitalModel : PageModel
    {
      private readonly IRepositorioMascota _repositorioMascota;
      public Mascota mascota {get; set; }
      public SignoVital signoVital {get; set; }

      public SignovitalModel (IRepositorioMascota mascota)
      {
        this._repositorioMascota = _repositorioMascota;
      }
        public IActionResult OnGet(int id)
        {
          mascota = _repositorioMascota.ObtenerMascota(id);

          if (mascota == null){
            return NotFound();
          }else{
            return Page();
          }
        }

        public IActionResult OnPost(int id, SignoVital signoVital){
          _repositorioMascota.AgregarSignoVital(id, signoVital);
          return RedirectToPage("Index");
        }
    }
}
