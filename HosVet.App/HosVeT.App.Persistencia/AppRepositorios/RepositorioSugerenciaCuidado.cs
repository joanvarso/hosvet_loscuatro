using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia
{
    public class RepositorioSugerenciaCuidado : IRepositorioSugerenciaCuidado
    {    
      private readonly DbConnection _dbConnection;  
      public RepositorioSugerenciaCuidado(DbConnection _dbConnection)
        {
          //Conexión a la base de datos
            _dbConnection = _dbConnection;
        }

         IEnumerable<SugerenciaCuidado> IRepositorioSugerenciaCuidado.ObtenerTodasLasSugerenciaCuidado (){

           return _dbConnection.SugerenciaCuidados;
           
         }
         SugerenciaCuidado IRepositorioSugerenciaCuidado.AgregarSugerenciaCuidado (SugerenciaCuidado sugerenciaCuidado){

           //Obtener SugerenciaCuidado añadidos
           var sugerenciaCuidadoAdicionado = _dbConnection.SugerenciaCuidados.Add(sugerenciaCuidado);
           //Guardar cambios en la base de datos
           _dbConnection.SaveChanges();
           //retornar SugerenciaCuidado añadido
           return sugerenciaCuidadoAdicionado.Entity;

         }
         SugerenciaCuidado IRepositorioSugerenciaCuidado.ActualizarSugerenciaCuidado(SugerenciaCuidado sugerenciaCuidado){

           //Buscando SugerenciaCuidado a actualizar
           var SugerenciaCuidadoEncontrada = _dbConnection.SugerenciaCuidados.FirstOrDefault(sc => sc.Id == sugerenciaCuidado.Id);
           
           if(SugerenciaCuidadoEncontrada != null){

             SugerenciaCuidadoEncontrada.FechaHora = sugerenciaCuidado.FechaHora;
             SugerenciaCuidadoEncontrada.Descripcion = sugerenciaCuidado.Descripcion;
             _dbConnection.SaveChanges();

           }
           return SugerenciaCuidadoEncontrada;

         }
         void IRepositorioSugerenciaCuidado.BorrarSugerenciaCuidado (int idSugerenciaCuidado){

           //Buscando SugerenciaCuidado a eliminar
           var sugerenciaCuidadoEncontrada = _dbConnection.SugerenciaCuidados.FirstOrDefault(sc => sc.Id == idSugerenciaCuidado);
           if(sugerenciaCuidadoEncontrada == null)
           return;
           //eliminando SugerenciaCuidado encontrada
           _dbConnection.SugerenciaCuidados.Remove(sugerenciaCuidadoEncontrada);
           //guardando cambios en la base de datos
           _dbConnection.SaveChanges();

         }
         SugerenciaCuidado IRepositorioSugerenciaCuidado.ObtenerSugerenciaCuidado (int idSugerenciaCuidado){

           //Buscando SugerenciaCuidado
           return _dbConnection.SugerenciaCuidados.FirstOrDefault(sc => sc.Id == idSugerenciaCuidado);
        
         }

    }
}