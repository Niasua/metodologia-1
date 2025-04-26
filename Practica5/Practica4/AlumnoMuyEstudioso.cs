using System;
using MetodologíasDeProgramaciónI;

namespace Practica5 {
    public class AlumnoMuyEstudioso : Alumno {
        public AlumnoMuyEstudioso(string n, int d, int legajo, int promedio) : base(n, d, legajo, promedio) {

        }

        // reimplementacion de responderPregunta
        public override int responderPregunta(int pregunta) {
            return pregunta % 3;
        }
    }
}