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

           return _dbConnection.SugerenciaCuidado;
           
         }
         SugerenciaCuidado IRepositorioSugerenciaCuidado. AgregarSugerenciaCuidado (SugerenciaCuidado sugerenciaCuidado){

           //Obtener SugerenciaCuidado añadidos
           var sugerenciaCuidadoAdicionado = _dbConnection.SugerenciaCuidado.Add(sugerenciaCuidado);
           //Guardar cambios en la base de datos
           _dbConnection.SaveChanges();
           //retornar SugerenciaCuidado añadido
           return sugerenciaCuidadoAdicionado.Entity;

         }
         SugerenciaCuidado IRepositorioSugerenciaCuidado.SugerenciaCuidado(SugerenciaCuidado SugerenciaCuidado){

           //Buscando SugerenciaCuidado a actualizar
           var SugerenciaCuidadoEncontrada = _dbConnection.SugerenciaCuidado.FirstOrDefault(sc => sc.Id == SugerenciaCuidado.Id);
           
           if(signoVitalEncontrado != null){

             SugerenciaCuidadoEncontrada.FechaHora = SugerenciaCuidado.FechaHora;
             SugerenciaCuidadoEncontrada.Descripcion = SugerenciaCuidado.Descripcion;
             _dbConnection.SaveChanges();

           }
           return SugerenciaCuidadoEncontrada;

         }
         void IRepositorioSugerenciaCuidado.BorrarSugerenciaCuidado (int idSugerenciaCuidado){

           //Buscando SugerenciaCuidado a eliminar
           var sugerenciaCuidadoEncontrada = _dbConnection.SugerenciaCuidado.FirstOrDefault(sc => sc.Id == idSugerenciaCuidado);
           if(sugerenciaCuidadoEncontrada == null)
           return;
           //eliminando SugerenciaCuidado encontrada
           _dbConnection.SugerenciaCuidado.Remove(sugerenciaCuidadoEncontrada);
           //guardando cambios en la base de datos
           _dbConnection.SaveChanges();

         }
         SugerenciaCuidado IRepositorioSugerenciaCuidado.ObtenerSugerenciaCuidado (int idSugerenciaCuidado){

           //Buscando SugerenciaCuidado
           return _dbConnection.SugerenciaCuidado.FirstOrDefault(sc => sc.Id == idSugerenciaCuidado);
        
         }

    }
}