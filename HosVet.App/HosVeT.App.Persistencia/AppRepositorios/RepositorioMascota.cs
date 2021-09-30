using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {    
      private readonly DbConnection _dbConnection;  
      public RepositorioMascota(DbConnection _dbConnection)
        {
          //Conexión a la base de datos
            _dbConnection = _dbConnection;
        }

         IEnumerable<Mascota> IRepositorioMascota.ObtenerTodasLasMascota (){

           return _dbConnection.Mascota;
           
         }

         Mascota IRepositorioMascota.AgregarMascota (Mascota mascota){

           //Obtener Mascota añadidos
           var mascotaAdicionado = _dbConnection.Mascota.Add(mascota);
           //Guardar cambios en la base de datos
           _dbConnection.SaveChanges();
           //retornar Mascota añadido
           return mascotaAdicionado.Entity;

         }

         Mascota IRepositorioMascota.Mascota(Mascota mascota){

           //Buscando Mascota a actualizar
           var mascotaEncontrada = _dbConnection.Mascota.FirstOrDefault(m => m.Id == Mascota.Id);
           
           if(signoVitalEncontrado != null){

             SugerenciaCuidadoEncontrada.FechaHora = SugerenciaCuidado.FechaHora;
             SugerenciaCuidadoEncontrada.Descripcion = SugerenciaCuidado.Descripcion;
             _dbConnection.SaveChanges();

           }
           return SugerenciaCuidadoEncontrada;

         }
         void IRepositorioMascota.BorrarSugerenciaCuidado (int idSugerenciaCuidado){

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