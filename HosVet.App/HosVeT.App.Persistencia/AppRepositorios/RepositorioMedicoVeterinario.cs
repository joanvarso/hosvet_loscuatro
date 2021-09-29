using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia
{
    public class RepositorioMedicoVeterinario : IRepositorioMedicoVeterinario
    {
        private readonly DbConnection _dbConnection;  
        public RepositorioMedicoVeterinario(DbConnection dbConnection)
        {
            //Conexión a la base de datos
            _dbConnection = dbConnection;
        }
        public MedicoVeterinario ActualizarMedico(MedicoVeterinario medicoVeterinario)
        {
            //Buscando medico veterinario a actualizar
            var medicoVeterinarioEncontrado = _dbConnection.MedicoVeterinarios.FirstOrDefault(m => m.Id == medicoVeterinario.Id);
            if (medicoVeterinarioEncontrado != null)
            {
                medicoVeterinarioEncontrado.Nombre = medicoVeterinario.Nombre;
                medicoVeterinarioEncontrado.Apellidos = medicoVeterinario.Apellidos;
                medicoVeterinarioEncontrado.NumeroTelefono = medicoVeterinario.NumeroTelefono;
                medicoVeterinarioEncontrado.Genero = medicoVeterinario.Genero;
                medicoVeterinarioEncontrado.Especialidad = medicoVeterinario.Especialidad;
                medicoVeterinarioEncontrado.Codigo = medicoVeterinario.Codigo;
                medicoVeterinarioEncontrado.RegistroRethus = medicoVeterinario.RegistroRethus;
                medicoVeterinarioEncontrado.CantidadPacientes = medicoVeterinario.CantidadPacientes;

                _dbConnection.SaveChanges();
            }
            return medicoVeterinarioEncontrado;
        }
        public MedicoVeterinario AgregarMedico(MedicoVeterinario medicoVeterinario)
        {
            //Obtener medicoveterinario añadidos
            var medicoVeterinarioAdicionado = _dbConnection.MedicoVeterinarios.Add(medicoVeterinario);
            //Guardar cambios en la base de datos
            _dbConnection.SaveChanges();
            //retornar medicoveterinario añadido
            return medicoVeterinarioAdicionado.Entity;
        }
        public void BorrarMedico(int idMedicoVeterinario)
        {
            //Buscando MedicoVeterinario a eliminar
            var medicoVeterinarioEncontrado = _dbConnection.MedicoVeterinarios.FirstOrDefault(p => p.Id == idMedicoVeterinario);
            if (medicoVeterinarioEncontrado == null)
                return;
            //eliminando MedicoVeterinario encontrada
            _dbConnection.MedicoVeterinarios.Remove(medicoVeterinarioEncontrado);
            //guardando cambios en la base de datos
            _dbConnection.SaveChanges();
        }
        public MedicoVeterinario ObtenerMedico(int idMedicoVeterinario)
        {
            //buscar y retornar MedicoVeterinario
            return _dbConnection.MedicoVeterinarios.FirstOrDefault(p => p.Id == idMedicoVeterinario);
        }
        public IEnumerable<MedicoVeterinario> ObtenerTodasLosMedicos()
        {
            return _dbConnection.MedicoVeterinarios;
        }
    }

}