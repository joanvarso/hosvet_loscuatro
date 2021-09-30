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
         SugerenciaCuidado IRepositorioSugerenciaCuidado. AgregarSugerenciaCuidado (SignoVital signoVital){

           //Obtener SignoVital añadidos
           var signoVitalAdicionado = _dbConnection.SignoVital.Add(signoVital);
           //Guardar cambios en la base de datos
           _dbConnection.SaveChanges();
           //retornar SignoVital añadido
           return SignoVitalAdicionado.Entity;

         }
         SignoVital IRepositorioSugerenciaCuidado.ActualizarSignoVital(SignoVital signoVital){

           //Buscando SignoVital a actualizar
           var signoVitalEncontrado = _dbConnection.SignoVital.FirstOrDefault(sv => sv.Id == SignoVital.Id);
           
           if(signoVitalEncontrado != null){

             signoVitalEncontrado.FechaHora = signoVital.FechaHora;
             signoVitalEncontrado.TipoSigno = signoVital.TipoSigno;
             signoVitalEncontrado.Valor = signoVital.Valor;
             _dbConnection.SaveChanges();

           }
           return signoVitalEncontrado;

         }
         void IRepositorioSugerenciaCuidado.BorrarSignoVital (int idSignoVital){

           //Buscando SignoVital a eliminar
           var signoVitalEncontrado = _dbConnection.SignoVital.FirstOrDefault(sv => sv.Id == idSignoVital);
           if(signoVitalEncontrado == null)
           return;
           //eliminando SignoVital encontrada
           _dbConnection.SignoVital.Remove(signoVitalEncontrado);
           //guardando cambios en la base de datos
           _dbConnection.SaveChanges();

         }
         SignoVital IRepositorioSugerenciaCuidado.ObtenerSignoVital (int idSignoVital){

           //Buscando SignoVital
           return _dbConnection.SignoVital.FirstOrDefault(sv => sv.Id == idSignoVital);
        
         }

    }
}