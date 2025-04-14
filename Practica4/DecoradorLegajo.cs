using System;
using MetodologíasDeProgramaciónI;

namespace Practica4 {
    public class DecoradorLegajo: AlumnoDecorator {
    
        public DecoradorLegajo(IAlumno alumno) : base(alumno) {}

        public override string mostrarCalificacion() {
            string resultado = base.mostrarCalificacion();
            int index = resultado.IndexOf(" " + adicional.getCalificacion()); 
            resultado = resultado.Insert(index, " (" + adicional.getLegajo() + ")"); 
            return resultado;
        }
    }
}