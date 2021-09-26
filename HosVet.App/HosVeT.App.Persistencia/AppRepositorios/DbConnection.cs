using System;
using Microsoft.EntityFrameworkCore;
using HosVet.App.Dominio;
namespace HosVet.App.Persistencia
{
  /// <summary> Class<c>AppContext <c>
      /// Es el contexto de datos del proyecto, da la conexión a la base de datos y su mapeo
  /// </summary>
    public class DbConnection : DbContext

    {

      ///Mapeo de las entidades de la capa de dominio(HosVet.App.Dominio) en la capa de persistencia (HosVet.App.Persistencia)
      //Relaciona una entidad Persona con una tabla llamada Personas en la base de datos del proyecto 
      public DbSet<Persona> Personas { get; set; }
      //Relaciona una entidad Medico Veterinario con una tabla llamada MedicoVeterinarios en la base de datos del proyecto
      public DbSet<MedicoVeterinario> MedicoVeterinarios { get; set; }
      //Relaciona una entidad Auxiliar Veterinario con una tabla llamada AuxiliarVeterinarios en la base de datos del proyecto
      public DbSet<AuxiliarVeterinario> AuxiliarVeterinarios { get; set; }
      //Relaciona una entidad PropietarioDesignado con una tabla llamada PropietarioDesignados en la base de datos del proyecto
      public DbSet<PropietarioDesignado> PropietarioDesignados { get; set; }
      //Relaciona una entidad Mascota con la tabla Mascotas en la base de datos del proyecto
      public DbSet<Mascota> Mascotas { get; set; }
      //Relaciona una entidad SignoVital con la tabla llamada SignosVitales en la base de datos del proyecto
      public DbSet<SignoVital> SignosVitales { get; set; }
      //Relaciona una entidad Historia con la tabla llamada Historias en la base de datos del proyecto
      public DbSet<Historia> Historias { get; set; }
      //Relaciona una entidad SugerenciaCuidado con la tabla SugerenciaCuidados en la base de datos del proyecto
      public DbSet<SugerenciaCuidado> SugerenciaCuidados { get; set; }
      
      //Método que se usa para realizar la conexión con la Base de datos
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){

          if (!optionsBuilder.IsConfigured)
          {
              optionsBuilder
              //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasaData");
              //Método que se usa para al conexión a la base de datos
              //Data Source : Es la nombre de conexión de SQLServer, en mi caso es el nombre del PC
              //Trusted_Connection : en caso de tener verificación SQLServer, en vez de dar un usuario y una contraseña
                //se le indica True, para que use la Autenticación de Windows, eso lo ingresa de manera automática
              //Initial Catalog : Nombre de la base de datos
              .UseSqlServer("Data Source = DESKTOP-45IEF58; Trusted_Connection=True;Initial Catalog = HosVetData");
          }

    }
}
}
