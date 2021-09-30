using System;
using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;


namespace HosVet.App.Persistencia
{
    public interface IRepositorioMascota
    {
         
         IEnumerable<Mascota> ObtenerTodasLasMascota();
         Mascota AgregarMascota (Mascota mascota);
         Mascota ActualizarMascota (Mascota mascota);
         void BorrarMascota (int idMascota);
         Mascota ObtenerMascota (int idMascota);

    }
}