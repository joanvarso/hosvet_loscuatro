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
    public class historiaModel : PageModel
    {
      private readonly IRepositorioHistoria _repositorioHistoria;
      private readonly IRepositorioMascota _repositorioMascota;
      public Historia historia {get; set ;}
      public Mascota mascota {get; set; }
      public historiaModel (IRepositorioHistoria _repositorioHistoria,IRepositorioMascota _repositorioMascota)
      {
        this._repositorioHistoria = _repositorioHistoria;
        this._repositorioMascota = _repositorioMascota;
      }
        /*public void OnGet()
        {
          historia = new Historia();
        }*/
        public IActionResult OnGet(int id)
        {
          historia = new Historia();
          mascota = _repositorioMascota.ObtenerMascota(id);

          if (mascota == null){
            return NotFound();
          }else{
            return Page();
          }
        }
        
        public IActionResult OnPost(int id, Historia historia)
        {
          mascota = _repositorioMascota.ObtenerMascota(id);
          System.Console.WriteLine("Entidad Mascota "+mascota);
          System.Console.WriteLine("historia en Mascota "+mascota.Historia);
          //System.Console.WriteLine("id de la historia en Mascota"+mascota.Historia.Id);
          System.Console.WriteLine("id de la historia"+historia.Id);
          mascota.Historia = historia;
          _repositorioHistoria.AgregarHistoria(historia);
          return RedirectToPage("Index");
          
        }
    }
}
