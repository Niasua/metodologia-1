using System;
using MetodologíasDeProgramaciónI;

namespace Practica6 {
    public class DecoradorEstado: AlumnoDecorator {
    
        public DecoradorEstado(IAlumno alumno) : base(alumno) {}

        public override string mostrarCalificacion() {
            string resultado = base.mostrarCalificacion();
            if(base.getCalificacion() < 4) {
                resultado += " (DESAPROBADO)";
            } else if (base.getCalificacion() < 7) {
                resultado += " (APROBADO)";
            } else {
                resultado += " (PROMOCION)";        
            }

            return resultado;
        }
    }
}