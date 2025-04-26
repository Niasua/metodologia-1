using System;
using MetodologíasDeProgramaciónI;

namespace Practica5 {
    public class DecoradorRecuadro: AlumnoDecorator {
    
        public DecoradorRecuadro(IAlumno alumno) : base(alumno) {}

        public override string mostrarCalificacion() {
            string resultado = base.mostrarCalificacion();
            int largo = resultado.Length + 4;
            string borde = new string('*', largo);
            string nvoResultado = borde + "\n* " + resultado + " *\n" + borde;
            return nvoResultado;
        }
    }
}