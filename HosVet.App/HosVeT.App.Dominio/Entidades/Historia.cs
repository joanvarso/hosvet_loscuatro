using System;
using System.Collections.Generic;

namespace HosVet.App.Dominio
{
  /// <summary>Class <c>Historia</c>
      /// Modela la historia clínica relacioada con el cuidado en casa de la mascota
  /// </summary>Class 

  public class Historia{
    // Identificador único de la Historia
        public int Id { get; set; }
        // Descripcion detallada del diagnostico de la Mascota
        public string Diagnostico  { get; set; }
         // Descripción de la casa y actividad de la Mascota
        public string Entorno { get; set; }
        // Referencia la lista de sugerencias registradas en la Historia de la Mascota
        public List<SugerenciaCuidado> Sugerencias { get; set; }
  }
}