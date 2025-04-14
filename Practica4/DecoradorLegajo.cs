using System;
using MetodologíasDeProgramaciónI;

namespace Practica4 {
    public class DecoradorLegajo: AlumnoDecorator {
    
        public DecoradorLegajo(IAlumno alumno) : base(alumno) {}

        public override string mostrarCalificacion() {
            return adicional.getNombre() + " (" + adicional.getLegajo() + ") " + adicional.getCalificacion();
        }

    }
}