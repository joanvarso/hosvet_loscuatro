using System;
namespace HosVet.App.Dominio
{
/// <summary>Class <c>AuxiliarVeterinario</c>
    /// Modela un AuxiliarVeterinario que esta podra vigilar la mascota
/// </summary> 
    public class AuxiliarVeterinario : Persona
    {
        
    // Tarjeta profesional que identifica al auxiliar veterinario
    public string TarjetaProfesional {get;set;}
    // Horas laborales hechas por el auxiliar veterinario 
    public int HotasLaborales {get;set;}
    
    } 
}
