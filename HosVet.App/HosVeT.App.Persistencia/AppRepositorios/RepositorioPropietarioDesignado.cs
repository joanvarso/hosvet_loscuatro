using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia
{
  public class RepositorioPropietarioDesignado : IRepositorioPropietarioDesignado
  {
      private readonly DbConnection _dbConnection = new DbConnection();


    PropietarioDesignado IRepositorioPropietarioDesignado.ActualizarPropietarioDesignado(PropietarioDesignado propietarioDesignado)
    {

      //Buscando Propietario Designado a actualizar
      var propietarioDesignadoEncontrado = _dbConnection.PropietarioDesignados.FirstOrDefault(pd => pd.Id == propietarioDesignado.Id);

      if(propietarioDesignadoEncontrado != null){

        //actualizando atributos de la entidad propietario designado
        propietarioDesignadoEncontrado.Nombre = propietarioDesignado.Nombre;
        propietarioDesignadoEncontrado.Apellidos = propietarioDesignado.Apellidos;
        propietarioDesignadoEncontrado.Nombre = propietarioDesignado.Nombre;
        propietarioDesignadoEncontrado.NumeroTelefono = propietarioDesignado.NumeroTelefono;        
        propietarioDesignadoEncontrado.Correo = propietarioDesignado.Correo;

      }
      //retornando Propietario Designado actualizado
      return propietarioDesignadoEncontrado;

    }

    public PropietarioDesignado AgregarPropietarioDesignado(PropietarioDesignado propietarioDesignado)
    {

      //Obtener Propietario Designado añadido
           var propietarioDesignadoAdicionado = _dbConnection.PropietarioDesignados.Add(propietarioDesignado);
           //Guardar cambios en la base de datos
           _dbConnection.SaveChanges();
           //retornar Propietario Designado añadida
           return propietarioDesignadoAdicionado.Entity;

    }

    public void BorrarPropietarioDesignado(int idPropietarioDesignado)
    {

      //Buscando Propietario Designado a eliminar
      var propietarioDesignadoEncontrado = _dbConnection.PropietarioDesignados.FirstOrDefault(pd => pd.Id == idPropietarioDesignado);
      if(propietarioDesignadoEncontrado == null)
      return;
      //eliminando Propietario Designado encontrado
      _dbConnection.PropietarioDesignados.Remove(propietarioDesignadoEncontrado);
      //guardando cambios en la base de datos
      _dbConnection.SaveChanges();

    }

    PropietarioDesignado IRepositorioPropietarioDesignado.ObtenerPropietarioDesignado(int idPropietarioDesignado)
    {
      
      //Buscando Propietario Destinado
      var propietarioDesignadoEncontrado = _dbConnection.PropietarioDesignados.FirstOrDefault(pd => pd.Id == idPropietarioDesignado );
      //retornando el Propietario Designado encontrado
      return propietarioDesignadoEncontrado;

    }

    public IEnumerable<PropietarioDesignado> ObtenerTodosLosPropietariosDesignados()
    {

      //retornar todos los Propietarios Designados encontrados en el mapeo
      return _dbConnection.PropietarioDesignados;

    }
  }
}