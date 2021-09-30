using System;
using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;


namespace HosVet.App.Persistencia
{
    public interface IRepositorioSugerenciaCuidado
    {
         
         IEnumerable<SugerenciaCuidado> ObtenerTodosLosSugerenciaCuidado();
         SugerenciaCuidado AgregarSugerenciaCuidado (SugerenciaCuidado sugerenciaCuidado);
         SugerenciaCuidado ActualizarSugerenciaCuidado (SugerenciaCuidado sugerenciaCuidado);
         void BorrarSugerenciaCuidado (int idSugerenciaCuidado);
         SugerenciaCuidado ObtenerSugerenciaCuidado (int idSugerenciaCuidado);

    }
}