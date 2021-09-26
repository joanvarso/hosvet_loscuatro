using System.Collections.Generic;
using System.Linq;
using HosVet.App.Dominio;

namespace HosVet.App.Persistencia
{
    public class RepositorioMedicoVeterinario : IRepositorioMedicoVeterinario
    {
        /// <summary>
        /// Referencia al contexto de Mascota
        /// </summary>
        private readonly DbConnection _dbConnection;  
        public RepositorioMedicoVeterinario(DbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }
        public MedicoVeterinario ActualizarMedico(MedicoVeterinario medicoVeterinario)
        {
            var medicoVeterinarioEncontrado = _dbConnection.MedicoVeterinarios.FirstOrDefault(p => p.Id == medicoVeterinario.Id);
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
            var medicoVeterinarioAdicionado = _dbConnection.MedicoVeterinarios.Add(medicoVeterinario);
            _dbConnection.SaveChanges();
            return medicoVeterinarioAdicionado.Entity;
        }
        public void BorrarMedico(int idMedicoVeterinario)
        {
            var medicoVeterinarioEncontrado = _dbConnection.MedicoVeterinarios.FirstOrDefault(p => p.Id == idMedicoVeterinario);
            if (medicoVeterinarioEncontrado == null)
                return;
            _dbConnection.MedicoVeterinarios.Remove(medicoVeterinarioEncontrado);
            _dbConnection.SaveChanges();
        }
        public MedicoVeterinario GetMedico(int idMedicoVeterinario)
        {
            return _dbConnection.MedicoVeterinarios.FirstOrDefault(p => p.Id == idMedicoVeterinario);
        }
        public IEnumerable<MedicoVeterinario> ObtenerTodasLosMedicos()
        {
            return _dbConnection.MedicoVeterinarios;
        }
    }

}