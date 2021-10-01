using System;
using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAuxiliarVeterinario
    {
         
         IEnumerable<AuxiliarVeterinario> ObtenerTodosLosAuxiliarVeterinarios ();
         AuxiliarVeterinario AgregarAuxiliarVeterinario (AuxiliarVeterinario auxiliarVeterinario);
         AuxiliarVeterinario ActualizarAuxiliarVeterinario (AuxiliarVeterinario auxiliarVeterinario);
         void BorrarAuxiliarVeterinario (int idAuxiliarVeterinario);
         AuxiliarVeterinario ObtenerAuxiliarVeterinario (int idAuxiliarVeterinario);
         void AsignarPaciente();
         
    }
}