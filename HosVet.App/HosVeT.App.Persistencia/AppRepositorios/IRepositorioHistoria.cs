using System;
using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;


namespace HosVeT.App.Persistencia
{
    public interface IRepositorioHistoria
    {
         
         IEnumerable<Historia> ObtenerTodasLasHistorias();
         Historia AgregarHistoria (Historia historia);
         Historia ActualizarHistoria (Historia historia);
         void BorrarHistoria (int idHistoria);
         Historia ObtenerHistoria (int idHistoria);

    }
}