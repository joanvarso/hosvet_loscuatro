using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia
{
    public class RepositorioAuxiliarVeterinario : IRepositorioAuxiliarVeterinario
    {
        
        private readonly DbConnection _dbConnection = new DbConnection();
    AuxiliarVeterinario IRepositorioAuxiliarVeterinario.ActualizarAuxiliarVeterinario(AuxiliarVeterinario auxiliarVeterinario)
    {
      
      //Buscando auxiliar veterinario a actualizar
      var auxiliarVeterinarioEncontrado = _dbConnection.AuxiliarVeterinarios.FirstOrDefault(av => av.Id == auxiliarVeterinario.Id);

      if(auxiliarVeterinarioEncontrado != null){
        //actulizando campos de la entidad
        auxiliarVeterinarioEncontrado.Nombre = auxiliarVeterinario.Nombre;
        auxiliarVeterinarioEncontrado.Apellidos = auxiliarVeterinario.Apellidos;
        auxiliarVeterinarioEncontrado.NumeroTelefono = auxiliarVeterinario.NumeroTelefono;
        auxiliarVeterinarioEncontrado.TarjetaProfesional = auxiliarVeterinario.TarjetaProfesional;
        //corregir HotasLaborales por HorasLaborales
        auxiliarVeterinarioEncontrado.HotasLaborales = auxiliarVeterinario.HotasLaborales;
        _dbConnection.SaveChanges();
        
      }
      //retornando auxiliar veterinario actualizado
      return auxiliarVeterinarioEncontrado;
    }

    AuxiliarVeterinario IRepositorioAuxiliarVeterinario.AgregarAuxiliarVeterinario(AuxiliarVeterinario auxiliarVeterinario)
    {
      
      //Obtener Auxiliar Veterinario añadido
      var auxiliarVeterinarioAñadido = _dbConnection.AuxiliarVeterinarios.Add(auxiliarVeterinario);
      //Guardar cambios en la base de datos
      _dbConnection.SaveChanges();
      //retornar Hitoria Añadida
      return auxiliarVeterinarioAñadido.Entity;

    }

    void IRepositorioAuxiliarVeterinario.AsignarPaciente()
    {
      throw new System.NotImplementedException();
    }

    void IRepositorioAuxiliarVeterinario.BorrarAuxiliarVeterinario(int idAuxiliarVeterinario)
    {
      
      //Buscando auxiliar veterinario a eliminar
      var auxiliarVeterinarioEncontrado = _dbConnection.AuxiliarVeterinarios.FirstOrDefault(av => av.Id == idAuxiliarVeterinario);
      if(auxiliarVeterinarioEncontrado == null)
      return;
      //eliminando auxiliar veterinario
      _dbConnection.AuxiliarVeterinarios.Remove(auxiliarVeterinarioEncontrado);
      //guardando cambios en la base de datos
      _dbConnection.SaveChanges();
      
    }

    AuxiliarVeterinario IRepositorioAuxiliarVeterinario.ObtenerAuxiliarVeterinario(int idAuxiliarVeterinario)
    {
      
      //Buscando auxiliar veterinario
      var auxiliarVeterinarioEncontrado = _dbConnection.AuxiliarVeterinarios.FirstOrDefault(av => av.Id == idAuxiliarVeterinario);
      //retornando el auxiliar veterinario encontrado
      return auxiliarVeterinarioEncontrado;

    }

    IEnumerable<AuxiliarVeterinario> IRepositorioAuxiliarVeterinario.ObtenerTodosLosAuxiliarVeterinarios()
    {
      
      return _dbConnection.AuxiliarVeterinarios;

    }
  }
}