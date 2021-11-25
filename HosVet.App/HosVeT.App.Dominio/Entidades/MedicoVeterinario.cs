using System;
namespace HosVet.App.Dominio
{
/// <summary>Class <c>MedicoVeterinario</c>
    /// Modela un MedicoVeterinario que podra modificar la historia de la mascota
/// </summary> 
    public class MedicoVeterinario : Persona
    {
        
    // Especialidad del medico veterinario
    public string Especialidad {get;set;}
    // Codigo unico del medico veterinario
    public string Codigo {get;set;}
    // Registro Unico Nacional del Talento Humano
    public string RegistroRethus {get;set;}
    // Cantidad de pacientes que esta atendiendo el medico
    public int CantidadPacientes {get;set;}
    
    } 
}