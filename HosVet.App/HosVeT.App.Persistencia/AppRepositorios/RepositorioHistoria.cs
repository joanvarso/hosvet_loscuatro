using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia
{
    public class RepositorioHistoria : IRepositorioHistoria
    {    
      private readonly DbConnection _dbConnection;  
      public RepositorioHistoria(DbConnection _dbConnection)
        {
          //Conexión a la base de datos
            _dbConnection = _dbConnection;
        }

         IEnumerable<Historia> IRepositorioHistoria.ObtenerTodasLasHistorias (){

           return _dbConnection.Historias;
           
         }
         Historia IRepositorioHistoria. AgregarHistoria (Historia historia){

           //Obtener historia añadida
           var historiaAdicionada = _dbConnection.Historias.Add(historia);
           //Guardar cambios en la base de datos
           _dbConnection.SaveChanges();
           //retornar Historia añadida
           return historiaAdicionada.Entity;

         }
         Historia IRepositorioHistoria.ActualizarHistoria (Historia historia){

           //Buscando historia a actualizar
           var historiaEncontrada = _dbConnection.Historias.FirstOrDefault(h => h.Id == historia.Id);
           
           if(historiaEncontrada != null){

             historiaEncontrada.Diagnostico = historia.Diagnostico;
             historiaEncontrada.Entorno = historia.Entorno;
             historiaEncontrada.Sugerencias = historia.Sugerencias;
             _dbConnection.SaveChanges();

           }
           return historiaEncontrada;

         }
         void IRepositorioHistoria.BorrarHistoria (int idHistoria){

           //Buscando historia a eliminar
           var historiaEncontrada = _dbConnection.Historias.FirstOrDefault(h => h.Id == idHistoria);
           if(historiaEncontrada == null)
           return;
           //eliminando historia encontrada
           _dbConnection.Historias.Remove(historiaEncontrada);
           //guardando cambios en la base de datos
           _dbConnection.SaveChanges();

         }
         Historia IRepositorioHistoria.ObtenerHistoria (int idHistoria){

           //Buscando historia
           var historiaEncontrada = _dbConnection.Historias.FirstOrDefault(h => h.Id == idHistoria);
           //retornando la historia encontrada
           return historiaEncontrada;

         }

    }
}