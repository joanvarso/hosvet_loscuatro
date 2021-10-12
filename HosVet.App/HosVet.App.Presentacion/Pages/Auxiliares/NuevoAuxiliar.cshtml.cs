using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HosVet.App.Dominio;
using HosVet.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HosVet.App.Presentacion.Pages.Auxiliares
{
    public class NuevoAuxiliarModel : PageModel
    {
        public readonly IRepositorioAuxiliarVeterinario _repoAuxiliarVeterinario;
        public AuxiliarVeterinario auxiliarVeterinario {get;set;}
        public NuevoAuxiliarModel (IRepositorioAuxiliarVeterinario _repoAuxiliarVeterinario)
        {
            this._repoAuxiliarVeterinario = _repoAuxiliarVeterinario;
        } 
        public void OnGet()
        {
            auxiliarVeterinario = new AuxiliarVeterinario();
        }

        public IActionResult OnPost(AuxiliarVeterinario auxiliarVeterinario)
        {
            _repoAuxiliarVeterinario.AgregarAuxiliarVeterinario(auxiliarVeterinario);
            return RedirectToPage("Index");
        }
    }
}
