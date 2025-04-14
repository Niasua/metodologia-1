using System;
using MetodologíasDeProgramaciónI;

namespace Practica4 {
    public class DecoradorOrdenSecuencial: AlumnoDecorator {
        private static int contador = 1;
        private int numero;
        public DecoradorOrdenSecuencial(IAlumno alumno) : base(alumno) {
            this.numero = contador;
            contador++;
        }

        public override string mostrarCalificacion() {
            return numero + ") " + base.mostrarCalificacion();
        }
    }
}