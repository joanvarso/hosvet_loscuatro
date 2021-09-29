using System;
using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;


namespace HosVet.App.Persistencia
{
    public interface IRepositorioSignoVital
    {
         
         IEnumerable<SignoVital> ObtenerTodosLosSignoVital();
         Signovital AgregarSignoVital (SignoVital signoVital);
         Signovital ActualizarSignoVital (SignoVital SignoVital);
         void BorrarSignoVital (int idSignoVital);
         Signovital ObtenerSignoVital (int idSignoVital);

    }
}