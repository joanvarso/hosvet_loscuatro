using System;
using System.Collections.Generic;

namespace HosVet.App.Dominio
{
 /// <summary>Class <c>SugerenciaCuidado</c>
     /// Modela las sugerencias de cuidado de la Mascota
/// </summary>       
    public class SugerenciaCuidado 
    {
        // Identificador único de cada SugerenciaCuidado
        public int Id { get; set; }
        /// Fecha y hora en que se escribe la sugerencia
        public DateTime FechaHora  { get; set; }
         /// Texto que detalla la sugerencia
        public string Descripcion {get;set;}
    }
  }