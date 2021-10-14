using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HosVet.App.Dominio;
using HosVet.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HosVet.App.Presentacion.Pages.MedicosVeterinarios
{
    public class NuevoVeterinarioModel : PageModel
    {
        public readonly IRepositorioMedicoVeterinario _repoMedico;
        public MedicoVeterinario medicoVeterinario {get; set;}
        public NuevoVeterinarioModel(IRepositorioMedicoVeterinario _repoMedico)
        {
            this._repoMedico = _repoMedico;
        }
        public void OnGet()
        {
            medicoVeterinario = new MedicoVeterinario();
        }
        public IActionResult OnPost(MedicoVeterinario medicoVeterinario)
        {
            _repoMedico.AgregarMedico(medicoVeterinario);
            return RedirectToPage("Index");
        }
    }
}
