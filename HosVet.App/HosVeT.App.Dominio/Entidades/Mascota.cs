using System;
namespace HosVet.App.Dominio
{
/// <summary>Class <c>Paciente</c>
    /// Modela una Mascota que esta en atencion hospitalaria
/// </summary> 
    public class Mascota
    { 
        
    // Número que identifica a la mascota
    public int id {get;set;}
    // Nombre de la mascota
    public string Nombre {get;set;}
    // Lugar de residencia de la mascota     
    public string Direccion {get;set;}
    // Ciudad de residencia de la mascota
    public string Ciudad {get;set;}
    /// Coordenada de la dirección de la mascota
    public int Latitud {get;set;}
    // Coordenada de la dirección de la mascota
    public int Longitud {get;set;}
    // Indica que tipo de mascota es, Un Gato o Perro
    public string TipoMascota {get;set;}
    // Indica a que raza pertenece el animal doméstico
    public string Raza {get;set;}
    // Peso de la mascota
    public int Peso {get;set;}
    
    } 
}
