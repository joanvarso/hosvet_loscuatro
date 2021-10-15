using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia
{
    public class RepositorioMascota : IRepositorioMascota
    {    
      private readonly DbConnection _dbConnection = new DbConnection();  
      /*public RepositorioMascota(DbConnection _dbConnection)
        {
          //Conexión a la base de datos
            _dbConnection = _dbConnection;
        }*/

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
           
          //System.Console.WriteLine("Mascota esta nula?? ");
          //System.Console.WriteLine(mascota == null);
          //System.Console.WriteLine(mascota.Id == 0);
          //System.Console.WriteLine(mascota.Nombre == "Taras");
          var mascotaEncontrada = _dbConnection.Mascotas.Find(mascota.Id);
           //var mascotaEncontrada = _dbConnection.Mascotas.FirstOrDefault(m => m.Id == mascota.Id);
           //System.Console.WriteLine("MascotaEncontrada esta nula?? ");
           //System.Console.WriteLine(mascotaEncontrada == null);
           
           //System.Console.WriteLine(mascotaEncontrada.Nombre = mascota.Nombre);
           

           if(mascotaEncontrada != null){
             //System.Console.WriteLine("\nLa mascota encontrada no esta nula y se va actualizar");

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

    MedicoVeterinario IRepositorioMascota.AsignarMedico(int idMascota, int idMedicoVeterinario)
    {
      throw new System.NotImplementedException();
    }

    void IRepositorioMascota.AgregarSignoVital(int IdMascota, SignoVital signoVital)
    {
      //Buscando Mascota para agregar signo vital
      var mascota = _dbConnection.Mascotas.Find(IdMascota);
      if(mascota != null)
      {
        if(mascota.SignosVitales != null)
        {
          //Agregando Signo Vital si no está vacío
          mascota.SignosVitales.Add(signoVital);
        }else
        {
          //Agregando Signo Vital si está vacío
          mascota.SignosVitales = new List<SignoVital>();
          mascota.SignosVitales.Add(signoVital);
        }
      }

      //Actualizando Datos de la entidad Mascota
      var mascotaEncontrada = _dbConnection.Mascotas.Find(mascota.Id);
           if(mascotaEncontrada != null){

             mascotaEncontrada.Nombre = mascota.Nombre;
             mascotaEncontrada.Direccion = mascota.Direccion;
             mascotaEncontrada.Ciudad = mascota.Ciudad;
             mascotaEncontrada.Latitud = mascota.Latitud;
             mascotaEncontrada.Longitud = mascota.Longitud;
             mascotaEncontrada.TipoMascota = mascota.TipoMascota;
             mascotaEncontrada.Raza = mascota.Raza;
             mascotaEncontrada.Peso = mascota.Peso;
             //mascotaEncontrada.SignosVitales = mascota.SignosVitales;
             _dbConnection.SaveChanges();

           }
    }

Historia IRepositorioMascota.AgregarHistoria(int IdMascota, Historia historia)
    {
      //Buscando Mascota para agregar signo vital
      var mascota = _dbConnection.Mascotas.Find(IdMascota);
      if(mascota != null)
      {
        if(mascota.HistoriaId != null)
        {
          //var historia = _dbConnection.Historia.Find(id)
          //Buscando historia a actualizar
           var historiaEncontrada = _dbConnection.Historias.FirstOrDefault(h => h.Id == historia.Id);
           
           if(historiaEncontrada != null){
             //actualizando atributos de la entidad
             historiaEncontrada.Diagnostico = historia.Diagnostico;
             historiaEncontrada.Entorno = historia.Entorno;
             historiaEncontrada.Sugerencias = historia.Sugerencias;
             _dbConnection.SaveChanges();

           }
          //Agregando Signo Vital si no está vacío
          mascota.HistoriaId = historia.Id;
        }else
        {
          //Agregando Signo Vital si está vacío
          var historiaAdicionada = _dbConnection.Historias.Add(historia);
          _dbConnection.SaveChanges();
        }
      }

      //Actualizando Datos de la entidad Mascota
      var mascotaEncontrada = _dbConnection.Mascotas.Find(mascota.Id);
           if(mascotaEncontrada != null){

             mascotaEncontrada.Nombre = mascota.Nombre;
             mascotaEncontrada.Direccion = mascota.Direccion;
             mascotaEncontrada.Ciudad = mascota.Ciudad;
             mascotaEncontrada.Latitud = mascota.Latitud;
             mascotaEncontrada.Longitud = mascota.Longitud;
             mascotaEncontrada.TipoMascota = mascota.TipoMascota;
             mascotaEncontrada.Raza = mascota.Raza;
             mascotaEncontrada.Peso = mascota.Peso;
             //mascotaEncontrada.SignosVitales = mascota.SignosVitales;
             _dbConnection.SaveChanges();

           }
    }

    /*
             MedicoVeterinario IRepositorioMascota.AsignarMedico(int idMascota, int idMedicoVeterinario){

               var mascotaEncontrada = _dbConnection.Mascotas.FirstOrDefault(m => m.Id == idMascota);
               if(mascotaEncontrada != null){
                 var medicoVeterinarioEncontrado = _dbConnection.MedicoVeterinarios.Min(mv => mv.CantidadPacientes);
                 if(medicoVeterinarioEncontrado != null ){
                   //mascotaEncontrada.MedicoVeterinario = medicoVeterinarioEncontrado;
                   mascotaEncontrada.MedicoVeterinario = null;
                   _dbConnection.SaveChanges();
                 }
                 //return medicoVeterinarioEncontrado;
                 return null;           
               }
               return null;

             }*/


  }
}