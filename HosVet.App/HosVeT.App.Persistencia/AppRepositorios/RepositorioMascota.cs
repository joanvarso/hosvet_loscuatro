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

         Mascota IRepositorioMascota.AgregarMascota(Mascota mascota){

           //Obtener Mascota añadidos
           var mascotaAdicionada = _dbConnection.Mascota.Add(mascota);
           //Guardar cambios en la base de datos
           _dbConnection.SaveChanges();
           //retornar Mascota añadida
           return mascotaAdicionada.Entity;

         }

         Mascota IRepositorioMascota.ActualizarMascota(Mascota mascota){

           //Buscando Mascota a actualizar
           var mascotaEncontrada = _dbConnection.Mascota.FirstOrDefault(m => m.Id == mascota.Id);
           
           if(mascotaEncontrada != null){

             mascotaEncontrada.Nombre = mascota.Nombre;
             mascotaEncontrada.Direccion = mascota.Direccion;
             mascotaEncontrada.Ciudad = mascota.Ciudad;
             mascotaEncontrada.Latitud = mascota.Latitud;
             mascotaEncontrada.Longitud = mascota.Longitud;
             mascotaEncontrada.TipoMascota = mascota.TipoMascota;
             mascotaEncontrada.Raza = mascota.Raza;
             mascotaEncontrada.Peso = mascota.Peso;
             _dbConnection.SaveChanges();

           }
           return mascotaEncontrada;

         }
         void IRepositorioMascota.BorrarMascota(int idMascota){

           //Buscando Mascota a eliminar
           var mascotaEncontrada = _dbConnection.Mascota.FirstOrDefault(m => m.Id == idMascota);
           if(mascotaEncontrada == null)
           return;
           //eliminando Mascota encontrada
           _dbConnection.Mascota.Remove(mascotaEncontrada);
           //guardando cambios en la base de datos
           _dbConnection.SaveChanges();

         }
         Mascota IRepositorioMascota.ObtenerMascota(int idMascota){

           //Buscando Mascota
           return _dbConnection.Mascota.FirstOrDefault(m => m.Id == idMascota);
        
         }

    }
}