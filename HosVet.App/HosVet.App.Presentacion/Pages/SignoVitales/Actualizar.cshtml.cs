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
    public class ActualizarModel : PageModel
    {
      private readonly IRepositorioSignoVital _repositorioSignoVital;
      private readonly IRepositorioMascota _repositorioMascota;
      public SignoVital signoVital {get; set; }
      public Mascota mascota {get; set; }
      public ActualizarModel (IRepositorioSignoVital _repositorioSignoVital, IRepositorioMascota _repositorioMascota)
      {
        this._repositorioSignoVital = _repositorioSignoVital;
        this._repositorioMascota = _repositorioMascota;
      }
        public IActionResult OnGet(int id)
        {
          signoVital = _repositorioSignoVital.ObtenerSignoVital(id);
          System.Console.WriteLine("OnGet: "+ signoVital.Id + "\n" + signoVital.Valor);
          mascota = _repositorioMascota.ObtenerMascota(id);
          if (signoVital == null || mascota == null){
            return NotFound();
          }else{
            return Page();
          }
        }

        public IActionResult OnPost(SignoVital signoVital)
        {
          System.Console.WriteLine("OnPost: "+ signoVital.Id + "\n" + signoVital.Valor);
          _repositorioSignoVital.ActualizarSignoVital(signoVital);
          return RedirectToPage("Index");

        }
    }
}
