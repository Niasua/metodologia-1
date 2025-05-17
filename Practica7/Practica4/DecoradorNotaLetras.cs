using System;
using MetodologíasDeProgramaciónI;

namespace Practica7 {
    public class DecoradorNotaLetras : AlumnoDecorator {
    
        public DecoradorNotaLetras(IAlumno alumno) : base(alumno) {}

        public override string mostrarCalificacion() {
            string[] letras = ["CERO", "UNO", "DOS", "TRES", "CUATRO",
                               "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"];
            return base.mostrarCalificacion() + " (" + letras[adicional.getCalificacion()] + ")";
        }
    }
}