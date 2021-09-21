using System;
namespace HosVet.App.Dominio
{
/// <summary>Class <c>SignoVital</c>
    /// Modela un SignoVital que esta asociado con la Mascota
/// </summary> 
    public class SignoVital 
    {
        
    /// Id que identifica la toma del SignoVital
    public int Id {get;set;}
    /// Fecha y hora en que se toma el SignoVital
    public DateTime FechaHora  { get; set; }
    /// Tipo de signo tomado
    public Signo TipoSigno {get; set;}
    ///Valor del signo tomado
    public float Valor{get; set; }

    } 
}
