using System;
using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVeT.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPropietarioDesignado
    {

         IEnumerable<PropietarioDesignado> ObtenerTodosLosPropietariosDesignados();
         PropietarioDesignado AgregarPropietarioDesignado (PropietarioDesignado propietarioDesignado);
         PropietarioDesignado ActualizarPropietarioDesignado (PropietarioDesignado propietarioDesignado);
         void BorrarPropietarioDesignado (int idPropietarioDesignado);
         Historia ObtenerPropietarioDesignado (int idPropietarioDesignado);

    }
}