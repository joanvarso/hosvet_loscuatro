using System;
using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia
{
    public interface IRepositorioMedicoVeterinario
    {
       IEnumerable<MedicoVeterinario> ObtenerTodasLosMedicos();
       MedicoVeterinario AgregarMedico(MedicoVeterinario medicoVeterinario);
       MedicoVeterinario ActualizarMedico(MedicoVeterinario medicoVeterinario);
       void BorrarMedico(int idMedicoVeterinario);
       MedicoVeterinario GetMedico(int idMedicoVeterinario);       
    }
}