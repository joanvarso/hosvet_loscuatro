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

           return _dbConnection.Mascotas;
           
         }

         Mascota IRepositorioMascota.AgregarMascota(Mascota mascota){

           //Obtener Mascota añadidos
           var mascotaAdicionada = _dbConnection.Mascotas.Add(mascota);
           //Guardar cambios en la base de datos
           _dbConnection.SaveChanges();
           //retornar Mascota añadida
           return mascotaAdicionada.Entity;

         }

         Mascota IRepositorioMascota.ActualizarMascota(Mascota mascota){

           //Buscando Mascota a actualizar
           var mascotaEncontrada = _dbConnection.Mascotas.FirstOrDefault(m => m.Id == mascota.Id);
           
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
           var mascotaEncontrada = _dbConnection.Mascotas.FirstOrDefault(m => m.Id == idMascota);
           if(mascotaEncontrada == null)
           return;
           //eliminando Mascota encontrada
           _dbConnection.Mascotas.Remove(mascotaEncontrada);
           //guardando cambios en la base de datos
           _dbConnection.SaveChanges();

         }
         Mascota IRepositorioMascota.ObtenerMascota(int idMascota){

           //Buscando Mascota
           return _dbConnection.Mascotas.FirstOrDefault(m => m.Id == idMascota);
        
         }

         MedicoVeterinario IRepositorioMascota.AsignarMedico(int idMascota, int idMedicoVeterinario){

           var mascotaEncontrada = _dbConnection.Mascotas.FirstOrDefault(m => m.Id == idMascota);
           if(mascotaEncontrada != null){
             var medicoVeterinarioEncontrado = _dbConnection.MedicoVeterinarios.Min(mv => mv.CantidadPacientes);
             if(medicoVeterinarioEncontrado != null ){
               mascotaEncontrada.MedicoVeterinario = medicoVeterinarioEncontrado;
               _dbConnection.SaveChanges();
             }
             return medicoVeterinarioEncontrado;           
           }
           return null;
           
         }


    }
}