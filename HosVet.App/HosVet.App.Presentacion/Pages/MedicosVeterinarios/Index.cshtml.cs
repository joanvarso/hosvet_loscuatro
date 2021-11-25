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
    public class IndexModel : PageModel
    {
        public readonly IRepositorioMedicoVeterinario _repoMedicoVeterinario;
        public IEnumerable<MedicoVeterinario> medicosVeterinarios {get; set;}
        public IndexModel (IRepositorioMedicoVeterinario _repoMedicoVeterinario)
        {
            this._repoMedicoVeterinario = _repoMedicoVeterinario;
        }
        public void OnGet()
        {
            medicosVeterinarios = _repoMedicoVeterinario.ObtenerTodasLosMedicos();
        }
    }
}
