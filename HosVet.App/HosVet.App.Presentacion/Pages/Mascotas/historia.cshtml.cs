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
      public Historia historia {get; set;}
      public Mascota mascota {get; set;}
      public CrearModel (IRepositorioHistoria _repositorioHistoria)
      {
        this._repositorioHistoria = _repositorioHistoria;
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
          mascota.Historia = historia;
          _repositorioHistoria.AgregarHistoria(historia);
          return RedirectToPage("Index");
          
        }
    }
}
