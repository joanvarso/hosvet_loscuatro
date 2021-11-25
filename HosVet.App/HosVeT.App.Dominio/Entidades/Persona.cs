using System;

namespace HosVet.App.Dominio
{
    /// <summary>Class <c>Persona</c>
        /// Modela una Persona cuyos atributos serán heredados por otras entidades 
    /// </summary>
        public class Persona
        {
            //Numero que identifica a la persona
            public int Id {get; set;}
            //Nombre de la persona
            public String Nombre {get; set;}
            //Apellidos de la persona
            public String Apellidos {get; set;}
            //Numero telefonico de la persona
            public String NumeroTelefono {get; set;}
            //Genero de la persona
            public Genero Genero {set;get;}
        }
}