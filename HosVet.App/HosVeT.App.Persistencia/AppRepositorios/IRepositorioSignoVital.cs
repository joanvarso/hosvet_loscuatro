using System;
using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;


namespace HosVet.App.Persistencia
{
    public interface IRepositorioSignoVital
    {
         
         IEnumerable<SignoVital> ObtenerTodosLosSignoVital();
         SignoVital AgregarSignoVital (SignoVital signoVital);
         SignoVital ActualizarSignoVital (SignoVital signoVital);
         void BorrarSignoVital (int idSignoVital);
         SignoVital ObtenerSignoVital (int idSignoVital);

    }
}